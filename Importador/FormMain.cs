using CardonerSistemas.Framework.Base;
using ExcelDataReader;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace CS_Padron_Importador
{
    public partial class FormMain : Form
    {

        #region Declarations

        private const byte IdDocumentoTipoNoEspecificado = 1;

        private const byte ColumnaSeccion = 1;
        private const byte ColumnaCircuito = 2;
        private const byte ColumnaCodigoSeccion = 3;
        private const byte ColumnaCodigoCircuito = 4;
        private const byte ColumnaDocumentoTipo = 5;
        private const byte ColumnaDocumentoNumero = 6;
        private const byte ColumnaApellido = 7;
        private const byte ColumnaNombre = 8;
        private const byte ColumnaFechaNacimiento = 9;
        private const byte ColumnaGenero = 11;
        private const byte ColumnaDomicilio = 12;
        private const byte ColumnaLocalidad = 13;
        private const byte ColumnaCodigoPostal = 14;
        private const byte ColumnaNacionalidadTipo = 15;
        private const byte ColumnaNacionalidadTipoAlternativa = 16;

        const string CodigoSeparador = " - ";

        private string _folder = string.Empty;
        private readonly byte _idDistrito = 1;
        private byte _idSeccion;
        private short _idCircuito;
        private short _idCircuitoNuevo;
        private string _circuitoCodigo = string.Empty;
        private byte _idDocumentoTipoNuevo;
        private byte _idNacionalidadTipoNuevo;
        private int _idPersonaNuevo;

        private List<Models.Circuito> _circuitos;
        private List<Models.DocumentoTipo> _documentoTipos;
        private List<Models.NacionalidadTipo> _nacionalidadTipos;

        private int _numeroFilasImportadas = 0;

        #endregion Declarations

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public FormMain()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
            Models.CSPadronContext.ConnectionString = $"Server={Properties.Settings.Default.DatabaseServer};Database={Properties.Settings.Default.DatabaseDatabase};Trusted_Connection=False;User Id={Properties.Settings.Default.DatabaseUserId};Password={Properties.Settings.Default.DatabasePassword};TrustServerCertificate=True";
        }

        #region Files to import

        private void ButtonExaminar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                Description = "Seleccione la carpeta",
                UseDescriptionForTitle = true
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CheckedListBoxArchivos.Items.Clear();
                TextBoxCarpeta.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (TextBoxCarpeta.Text.Trim() == string.Empty)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            LabelEstado.Text = "Obteniendo lista de archivos desde la carpeta....";
            Application.DoEvents();
            _folder = TextBoxCarpeta.Text.Trim();
            try
            {
                string[] files = [.. Directory.EnumerateFiles(_folder, "*.xlsx", SearchOption.TopDirectoryOnly).Select(Path.GetFileName).OrderBy(Path.GetFileName)];
                CheckedListBoxArchivos.Items.AddRange(files);
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, $"Error al obtener la lista de archivos de la carpeta.\n\nError: {ex.Message}");
            }
            LabelEstado.Text = string.Empty;
            Cursor = Cursors.Default;
        }

        private void Seleccionar(bool value)
        {
            for (int i = 0; i < CheckedListBoxArchivos.Items.Count; i++)
            {
                CheckedListBoxArchivos.SetItemChecked(i, value);
            }
        }

        private void ButtonSeleccionarTodos_Click(object sender, EventArgs e)
        {
            Seleccionar(true);
        }

        private void ButtonSeleccionarNinguno_Click(object sender, EventArgs e)
        {
            Seleccionar(false);
        }

        #endregion Files to import

#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {
            if (CheckedListBoxArchivos.CheckedItems.Count == 0)
            {
                return;
            }

            HabilitarControlesImportacion(false);

            _numeroFilasImportadas = 0;
            Stopwatch stopWatch = new();
            stopWatch.Start();
            Collection<string> checkedItems = [];
            for (int i = 0; i < CheckedListBoxArchivos.CheckedItems.Count; i++)
            {
                checkedItems.Add(CheckedListBoxArchivos.CheckedItems[i].ToString());
            }
            for (int i = 0; i < checkedItems.Count; i++)
            {
                if (!ImportarArchivo(checkedItems[i].ToString()))
                {
                    stopWatch.Stop();
                    HabilitarControlesImportacion(true);
                    return;
                }
                CheckedListBoxArchivos.SetItemCheckState(i, CheckState.Unchecked);
            }
            stopWatch.Stop();
            HabilitarControlesImportacion(true);
            if (_numeroFilasImportadas == 0)
            {
                MessageBox.Show("No se han importado datos.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TimeSpan timeSpan = stopWatch.Elapsed;
                MessageBox.Show($"Se han importado {_numeroFilasImportadas:N0} personas.\n\nTiempo transcurrido: {timeSpan.Minutes} minutos y {timeSpan.Seconds} segundos.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private bool ImportarArchivo(string archivo)
        {
            Cursor = Cursors.WaitCursor;
            if (!AbrirYLeerArchivo(archivo, out DataSet? dataSet))
            {
                Cursor = Cursors.Default;
                return false;
            }

            // Inicializar información de progreso
            ProgressBarArchivo.Value = 0;
            ProgressBarArchivo.Visible = true;
            int cantidadFilas = dataSet.Tables[0].Rows.Count;
            int porcentajeAvance;
            int numeroFila = 0;
            LabelEstado.Text = $"Leyendo {cantidadFilas:N0} filas desde el archivo {archivo}...";
            Application.DoEvents();

            // Abrir nueva conexión a la base de datos
            using Models.CSPadronContext context = new();
            List<Models.Persona> personas = [];
            if (!CargarTablas(context))
            {
                Cursor = Cursors.Default;
                return false;
            }
            IDbContextTransaction transaction = context.Database.BeginTransaction();

            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                numeroFila++;
                if (!AsignarValores(context, personas, dataRow, numeroFila, archivo))
                {
                    transaction.Rollback();
                    ProgressBarArchivo.Visible = false;
                    Cursor = Cursors.Default;
                    return false;
                }
                _numeroFilasImportadas++;
                porcentajeAvance = numeroFila * 100 / cantidadFilas;
                if (porcentajeAvance != ProgressBarArchivo.Value)
                {
                    ProgressBarArchivo.Value = porcentajeAvance;
                    Application.DoEvents();
                }
            }

            LabelEstado.Text = $"Guardando {cantidadFilas:N0} personas en la base de datos...";
            Application.DoEvents();
            bool resultado = GuardarDatosEnBase(context, personas, archivo, transaction);
            LabelEstado.Text = string.Empty;
            ProgressBarArchivo.Visible = false;
            Cursor = Cursors.Default;
            return resultado;
        }


        private bool AbrirYLeerArchivo(string archivo, out DataSet? dataSet)
        {
            LabelEstado.Text = $"Abriendo y leyendo el archivo {archivo}....";
            Application.DoEvents();
            try
            {
                using FileStream stream = File.Open(Path.Combine(_folder, archivo), FileMode.Open, FileAccess.Read);
                using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
                dataSet = reader.AsDataSet();
                if (dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show($"No se han encontrado datos en el archivo '{archivo}'.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // Borro la primera fila correspondiente a los títulos de las columnas
                dataSet.Tables[0].Rows.RemoveAt(0);
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, $"Error al abrir y leer el archivo '{archivo}'.");
                dataSet = null;
                return false;
            }
        }

        private bool CargarTablas(Models.CSPadronContext context)
        {
            try
            {
                // Circuitos
                _circuitos = [];
                if (context.Circuito.Any())
                {
                    _idCircuitoNuevo = (short)(context.Circuito.Max(c => c.IdCircuito) + 1);
                }
                else
                {
                    _idCircuitoNuevo = 1;
                }

                // Tipos de documento
                _documentoTipos = [.. context.DocumentoTipo];
                if (_documentoTipos.Count != 0)
                {
                    _idDocumentoTipoNuevo = (byte)(_documentoTipos.Max(dt => dt.IdDocumentoTipo) + 1);
                }
                else
                {
                    _idDocumentoTipoNuevo = 1;
                }

                // Tipos de nacionalidades
                _nacionalidadTipos = [.. context.NacionalidadTipo];
                if (_nacionalidadTipos.Count != 0)
                {
                    _idNacionalidadTipoNuevo = (byte)(_nacionalidadTipos.Max(n => n.IdNacionalidadTipo) + 1);
                }
                else
                {
                    _idNacionalidadTipoNuevo = 1;
                }

                // Personas
                if (context.Persona.Any())
                {
                    _idPersonaNuevo = context.Persona.Max(p => p.IdPersona) + 1;
                }
                else
                {
                    _idPersonaNuevo = 1;
                }
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error al abrir la base de datos y pre-cargar las tablas necesarias.");
                return false;
            }
        }

        private bool GuardarDatosEnBase(Models.CSPadronContext context, List<Models.Persona> personas, string archivo, IDbContextTransaction transaction)
        {
            try
            {
                if (RadioButtonOptimizacionMaxima.Checked)
                {
                    context.SaveChanges();
                    context.Persona.BulkInsertOptimized(personas);
                }
                else if (RadioButtonOptimizacionIntermedia.Checked)
                {
                    context.Persona.AddRange(personas);
                    context.BulkSaveChanges();
                }
                else
                {
                    context.Persona.AddRange(personas);
                    context.SaveChanges();
                }
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, $"Error al guardar los datos en la base. Archivo '{archivo}'.");
                transaction.Rollback();
                return false;
            }
        }

        private bool AsignarValores(Models.CSPadronContext context, List<Models.Persona> personas, DataRow dataRow, int numeroFila, string archivo)
        {
            // Sección
            if (!AsignarValoresDeSeccion(context, dataRow, archivo, numeroFila))
            {
                return false;
            }

            // Circuito
            if (!AsignarValoresDeCircuito(context, dataRow, archivo, numeroFila))
            {
                return false;
            }

            // Tipo de documento
            if (!AsignarValoresDeTipoDeDocumento(context, dataRow, archivo, numeroFila, out byte idDocumentoTipo))
            {
                return false;
            }

            // Nacionalidad
            if (!AsignarValoresDeNacionalidad(context, dataRow, archivo, numeroFila, out byte idNacionalidadTipo))
            {
                return false;
            }

            // Número de documento
            if (!int.TryParse(dataRow[ColumnaDocumentoNumero].ToString(), out int documentoNumero))
            {
                MessageBox.Show($"No se pudo convertir el número de documento al valor numérico correspondiente.\n\nArchivo: {archivo}\nFila: {numeroFila:N0}\nValor: {dataRow[ColumnaDocumentoNumero]}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Fecha de nacimiento
            DateOnly? fechaNacimiento = null;
            if (!string.IsNullOrEmpty(dataRow[ColumnaFechaNacimiento].ToString()))
            {
                if (DateTime.TryParseExact(dataRow[ColumnaFechaNacimiento].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaNacimientoDT))
                {
                    fechaNacimiento = DateOnly.FromDateTime(fechaNacimientoDT);
                }
                else
                {
                    MessageBox.Show($"No se pudo convertir la fecha de nacimiento al valor fecha correspondiente.\n\nArchivo: {archivo}\nFila: {numeroFila:N0}\nValor: {dataRow[ColumnaFechaNacimiento]}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Código postal
            short? codigoPostal = null;
            if (!string.IsNullOrEmpty(dataRow[ColumnaCodigoPostal].ToString()) && short.TryParse(dataRow[ColumnaCodigoPostal].ToString(), out short codigoPostalTP))
            {
                codigoPostal = codigoPostalTP;
            }

            // Asigno los datos a la persona
            personas.Add(new()
            {
                IdPersona = _idPersonaNuevo,
                Apellido = dataRow[ColumnaApellido].ToString(),
                Nombre = dataRow[ColumnaNombre].ToString(),
                IdDocumentoTipo = idDocumentoTipo,
                DocumentoNumero = documentoNumero,
                Genero = dataRow[ColumnaGenero].ToString(),
                Domicilio = dataRow[ColumnaDomicilio].ToString(),
                Localidad = dataRow[ColumnaLocalidad].ToString(),
                FechaNacimiento = fechaNacimiento,
                CodigoPostal = codigoPostal,
                IdNacionalidadTipo = idNacionalidadTipo,
                IdCircuito = _idCircuito
            });
            _idPersonaNuevo++;
            return true;
        }

        private bool AsignarValoresDeSeccion(Models.CSPadronContext context, DataRow dataRow, string archivo, int numeroFila)
        {
            try
            {
                string codigoSeccion = dataRow[ColumnaCodigoSeccion].ToString();
                if (byte.TryParse(codigoSeccion, out byte idSeccion))
                {
                    if (idSeccion != _idSeccion)
                    {
                        Models.Seccion seccion = context.Seccion.Find(_idDistrito, idSeccion);
                        if (seccion is null)
                        {
                            string nombre = dataRow[ColumnaSeccion].ToString();
                            nombre = nombre[(nombre.IndexOf(CodigoSeparador) + CodigoSeparador.Length)..];
                            context.Seccion.Add(new()
                            {
                                IdDistrito = _idDistrito,
                                IdSeccion = idSeccion,
                                Nombre = nombre.ToTitleCaseAll()
                            });
                        }
                        _idSeccion = idSeccion;
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show($"No se pudo convertir el código de sección al valor numérico correspondiente.\n\nArchivo: {archivo}\nFila: {numeroFila:N0}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, $"Error al asignar los valores de la sección.\n\nArchivo: {archivo}\nFila: {numeroFila:N0}");
                return false;
            }
        }

        private bool AsignarValoresDeCircuito(Models.CSPadronContext context, DataRow dataRow, string archivo, int numeroFila)
        {
            try
            {
                string circuitoCodigo = dataRow[ColumnaCodigoCircuito].ToString();
                if (circuitoCodigo != _circuitoCodigo)
                {
                    Models.Circuito circuito = _circuitos.Find(c => c.IdDistrito == _idDistrito && c.IdSeccion == _idSeccion && c.CodigoNumero + c.CodigoLetra == circuitoCodigo);
                    if (circuito is null)
                    {
                        circuito = context.Circuito.FirstOrDefault(c => c.IdDistrito == _idDistrito && c.IdSeccion == _idSeccion && c.Codigo == circuitoCodigo);
                        if (circuito is null)
                        {
                            string circuitoCodigoNumeroString;
                            string? circuitoCodigoLetra;
                            if (circuitoCodigo.IsDigitsOnly())
                            {
                                circuitoCodigoNumeroString = circuitoCodigo;
                                circuitoCodigoLetra = null;
                            }
                            else
                            {
                                circuitoCodigoLetra = circuitoCodigo[^1..];
                                circuitoCodigoNumeroString = circuitoCodigo[..^1];
                            }
                            if (short.TryParse(circuitoCodigoNumeroString, out short circuitoCodigoNumero))
                            {
                                string nombre = dataRow[ColumnaCircuito].ToString();
                                nombre = nombre[(nombre.IndexOf(CodigoSeparador) + CodigoSeparador.Length)..];
                                _idCircuito = _idCircuitoNuevo;
                                circuito = new()
                                {
                                    IdCircuito = _idCircuito,
                                    IdDistrito = _idDistrito,
                                    IdSeccion = _idSeccion,
                                    CodigoNumero = circuitoCodigoNumero,
                                    CodigoLetra = circuitoCodigoLetra,
                                    Nombre = nombre.ToTitleCaseAll()
                                };
                                context.Circuito.Add(circuito);
                                _circuitos.Add(circuito);
                                _idCircuitoNuevo++;
                            }
                            else
                            {
                                MessageBox.Show($"No se pudo convertir el código de circuito al valor numérico correspondiente.\n\nArchivo: {archivo}\nFila: {numeroFila:N0}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            _idCircuito = circuito.IdCircuito;
                        }
                    }
                    else
                    {
                        _idCircuito = circuito.IdCircuito;
                    }
                    _circuitoCodigo = circuitoCodigo ?? string.Empty;
                }
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, $"Error al asignar los valores del circuito.\n\nArchivo: {archivo}\nFila: {numeroFila:N0}");
                return false;
            }
        }

        private bool AsignarValoresDeTipoDeDocumento(Models.CSPadronContext context, DataRow dataRow, string archivo, int numeroFila, out byte idDocumentoTipo)
        {
            try
            {
                string documentoSigla = dataRow[ColumnaDocumentoTipo].ToString();
                if (string.IsNullOrEmpty(documentoSigla))
                {
                    idDocumentoTipo = IdDocumentoTipoNoEspecificado;
                }
                else
                {
                    Models.DocumentoTipo documentoTipo = _documentoTipos.Find(dt => dt.Sigla == documentoSigla);
                    if (documentoTipo is not null)
                    {
                        idDocumentoTipo = documentoTipo.IdDocumentoTipo;
                    }
                    else
                    {
                        idDocumentoTipo = _idDocumentoTipoNuevo;
                        documentoTipo = new()
                        {
                            IdDocumentoTipo = idDocumentoTipo,
                            Sigla = documentoSigla,
                            Nombre = documentoSigla
                        };
                        context.DocumentoTipo.Add(documentoTipo);
                        _documentoTipos.Add(documentoTipo);
                        _idDocumentoTipoNuevo++;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, $"Error al asignar los valores del tipo de documento.\n\nArchivo: {archivo}\nFila: {numeroFila:N0}");
                idDocumentoTipo = 0;
                return false;
            }
        }

        private bool AsignarValoresDeNacionalidad(Models.CSPadronContext context, DataRow dataRow, string archivo, int numeroFila, out byte idNacionalidadTipo)
        {
            try
            {
                string nacionalidadTipoValor = dataRow[ColumnaNacionalidadTipo].ToString();
                if (string.IsNullOrEmpty(nacionalidadTipoValor))
                {
                    // Intento con la columna siguiente para los casos de las celdas desfasadas
                    nacionalidadTipoValor = dataRow[ColumnaNacionalidadTipoAlternativa].ToString();
                    if (string.IsNullOrEmpty(nacionalidadTipoValor))
                    {
                        MessageBox.Show($"La nacionalidad está vacía.\n\nArchivo: {archivo}\nFila: {numeroFila:N0}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        idNacionalidadTipo = 0;
                        return false;
                    }
                }

                if (nacionalidadTipoValor.IsDigitsOnly())
                {
                    // Intento con la columna siguiente para los casos de las celdas desfasadas
                    nacionalidadTipoValor = dataRow[ColumnaNacionalidadTipoAlternativa].ToString();
                }
                Models.NacionalidadTipo nacionalidadTipo = _nacionalidadTipos.Find(nt => nt.Nombre.Equals(nacionalidadTipoValor, StringComparison.CurrentCultureIgnoreCase));
                if (nacionalidadTipo is not null)
                {
                    idNacionalidadTipo = nacionalidadTipo.IdNacionalidadTipo;
                }
                else
                {
                    if (MessageBox.Show($"No se encontró la nacionalidad '{nacionalidadTipoValor}'\n\nArchivo: {archivo}\nFila: {numeroFila:N0}\n\n¿Desea crearla y continuar?", Program.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        idNacionalidadTipo = 0;
                        return false;
                    }
                    idNacionalidadTipo = _idNacionalidadTipoNuevo;
                    nacionalidadTipo = new()
                    {
                        IdNacionalidadTipo = idNacionalidadTipo,
                        Nombre = nacionalidadTipoValor.ToTitleCaseAll()
                    };
                    context.NacionalidadTipo.Add(nacionalidadTipo);
                    _nacionalidadTipos.Add(nacionalidadTipo);
                    _idNacionalidadTipoNuevo++;
                }
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, $"Error al asignar los valores de la nacionalidad.\n\nArchivo: {archivo}\nFila: {numeroFila:N0}");
                idNacionalidadTipo = 0;
                return false;
            }
        }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8604 // Possible null reference argument.

        private void HabilitarControlesImportacion(bool value)
        {
            TableLayoutPanelCarpeta.Enabled = value;
            CheckedListBoxArchivos.Enabled = value;
            TableLayoutPanelSeleccionar.Enabled = value;
            TableLayoutPanelIniciar.Enabled = value;
        }
    }
}