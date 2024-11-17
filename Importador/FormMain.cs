using CardonerSistemas.Framework.Base;
using ExcelDataReader;
using System.Data;
using System.Diagnostics;
using System.Globalization;

namespace CS_Padron_Importador
{
    public partial class FormMain : Form
    {
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

        const string CodigoSeparador = " - ";

        private string _folder = string.Empty;
        private Models.CSPadronContext _context;
        private readonly byte _idDistrito = 1;
        private byte _idSeccion;
        private short _idCircuito;
        private string _circuitoCodigo = string.Empty;
        private int _idPersona;
        private IEnumerable<Models.DocumentoTipo> _documentoTipos;
        private IEnumerable<Models.NacionalidadTipo> _nacionalidadTipos;
        private int _numeroFilasImportadas = 0;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public FormMain()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
            Models.CSPadronContext.ConnectionString = "Server=localhost;Database=CSPadron;Trusted_Connection=False;User Id=sa;Password=Tai1802Pei;TrustServerCertificate=True";
            ComboBoxCantidadLote.Items.AddRange([1, 10, 50, 100, 500, 1000, 5000]);
            ComboBoxCantidadLote.SelectedIndex = 5;
        }

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
            if (TextBoxCarpeta.Text.Trim() != string.Empty)
            {
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
                    MessageBox.Show($"Error al obtener la lista de archivos de la carpeta.\n\nError: {ex.Message}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor = Cursors.Default;
                LabelEstado.Text = string.Empty;
            }
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

#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {
            if (CheckedListBoxArchivos.CheckedItems.Count > 0)
            {
                HabilitarControlesImportacion(false);
                if (_context is null)
                {
                    _context = new();
                    _documentoTipos = _context.DocumentoTipo;
                    _nacionalidadTipos = _context.NacionalidadTipo;
                    if (_context.Persona.Any())
                    {
                        _idPersona = _context.Persona.Max(p => p.IdPersona) + 1;
                    }
                    else
                    {
                        _idPersona = 1;
                    }
                }
                _numeroFilasImportadas = 0;
                Stopwatch stopWatch = new();
                stopWatch.Start();
                for (int i = 0; i < CheckedListBoxArchivos.CheckedItems.Count; i++)
                {
                    if (!ImportarArchivo(CheckedListBoxArchivos.CheckedItems[i].ToString()))
                    {
                        stopWatch.Stop();
                        HabilitarControlesImportacion(true);
                        return;
                    }
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
                    MessageBox.Show($"Se han importado {_numeroFilasImportadas:N0} personas.\n\nTiempo transcurrido: {timeSpan.Minutes} minutos y {timeSpan.Seconds} segundos.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool ImportarArchivo(string archivo)
        {
            string errorMessage = string.Empty;
            Cursor = Cursors.WaitCursor;
            LabelEstado.Text = $"Abriendo el archivo {archivo}....";
            Application.DoEvents();
            try
            {
#pragma warning disable S1854 // Unused assignments should be removed
                errorMessage = "Error al abrir el archivo.";
#pragma warning restore S1854 // Unused assignments should be removed
                using FileStream stream = File.Open(Path.Combine(_folder, archivo), FileMode.Open, FileAccess.Read);
                using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
                errorMessage = "Error al leer el archivo.";
                DataSet dataSet = reader.AsDataSet();

                ProgressBarArchivo.Value = 0;
                ProgressBarArchivo.Maximum = dataSet.Tables[0].Rows.Count;
                ProgressBarArchivo.Visible = true;

                dataSet.Tables[0].Rows.RemoveAt(0);
                int numeroFila = 0;
                LabelEstado.Text = $"Leyendo {ProgressBarArchivo.Maximum:N0} filas desde el archivo {archivo}...";
                Application.DoEvents();
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    numeroFila++;
                    if (!AsignarValoresAPersona(row, numeroFila, archivo, new Models.Persona()))
                    {
                        ProgressBarArchivo.Visible = false;
                        Cursor = Cursors.Default;
                        return false;
                    }
                    _numeroFilasImportadas++;
                    ProgressBarArchivo.Value++;
                    Application.DoEvents();
                }
                errorMessage = "Error al guardar los datos en la base de datos.";
                LabelEstado.Text = $"Guardando {numeroFila:N0} personas en la base de datos...";
                Application.DoEvents();
                _context.BulkSaveChanges(new Z.BulkOperations.BulkOperationOptions() { BatchSize = int.Parse(ComboBoxCantidadLote.Text) });
                LabelEstado.Text = string.Empty;
                ProgressBarArchivo.Visible = false;
                Cursor = Cursors.Default;
                return true;
            }
            catch (Exception ex)
            {
                LabelEstado.Text = string.Empty;
                ProgressBarArchivo.Visible = false;
                MessageBox.Show($"{errorMessage}\nArchivo: {archivo}.\n\nError: {ex.Message}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return false;
            }
        }

        private bool AsignarValoresAPersona(DataRow row, int numeroFila, string archivo, Models.Persona persona)
        {
            string errorMessageField = string.Empty;
            string value;
            byte idDocumentoTipo;
            byte idNacionalidadTipo = 0;

            try
            {

                // Código de sección
#pragma warning disable S1854 // Unused assignments should be removed
                errorMessageField = "Código de sección";
                value = row[ColumnaCodigoSeccion].ToString();
                if (byte.TryParse(value, out byte idSeccion) && idSeccion != _idSeccion)
                {
                    Models.Seccion seccion = _context.Seccion.Find(_idDistrito, idSeccion);
                    if (seccion is null)
                    {
                        value = row[ColumnaSeccion].ToString();
                        value = value[(value.IndexOf(CodigoSeparador) + CodigoSeparador.Length)..];
                        _context.Seccion.Add(new()
                        {
                            IdDistrito = _idDistrito,
                            IdSeccion = idSeccion,
                            Nombre = value.ToTitleCaseAll()
                        });
                        _context.SaveChanges();
                    }
                    _idSeccion = idSeccion;
                }

                // Código de circuito
                errorMessageField = "Código de circuito";
                value = row[ColumnaCodigoCircuito].ToString();
                if (value != _circuitoCodigo) 
                {
                    Models.Circuito circuito = _context.Circuito.FirstOrDefault(c => c.IdDistrito == _idDistrito && c.IdSeccion == _idSeccion && c.Codigo == value);
                    if (circuito is null)
                    {
                        string? circuitoCodigoLetra;
                        if (value.IsDigitsOnly())
                        {
                            circuitoCodigoLetra = null;
                        }
                        else
                        {
                            circuitoCodigoLetra = value[^1..];
                            value = value[..^1];
                        }
                        if (!short.TryParse(value, out short circuitoCodigoNumero))
                        {
                            MessageBox.Show($"No se pudo obtener el componente numérico del Código de Circuito de la fila número {numeroFila:N0}.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Cursor = Cursors.Default;
                            return false;
                        }
                        if (_context.Circuito.Any())
                        {
                            _idCircuito = (short)(_context.Circuito.Max(c => c.IdCircuito) + 1);
                        }
                        else
                        {
                            _idCircuito = 1;
                        }
                        value = row[ColumnaCircuito].ToString();
                        value = value[(value.IndexOf(CodigoSeparador) + CodigoSeparador.Length)..];
                        _context.Circuito.Add(new()
                        {
                            IdCircuito = _idCircuito,
                            IdDistrito = _idDistrito,
                            IdSeccion = _idSeccion,
                            CodigoNumero = circuitoCodigoNumero,
                            CodigoLetra = circuitoCodigoLetra,
                            Nombre = value.ToTitleCaseAll()
                        });
                        _context.SaveChanges();
                    }
                    else
                    {
                        _idCircuito = circuito.IdCircuito;
                        _circuitoCodigo = circuito.Codigo;
                    }
                }

                // Tipo de documento
                errorMessageField = "Tipo de documento";
                value = row[ColumnaDocumentoTipo].ToString();
                if (string.IsNullOrEmpty(value))
                {
                    idDocumentoTipo = IdDocumentoTipoNoEspecificado;
                }
                else
                {
                    Models.DocumentoTipo documentoTipo = _documentoTipos.FirstOrDefault(dt => dt.Sigla == value);
                    if (documentoTipo is not null)
                    {
                        idDocumentoTipo = documentoTipo.IdDocumentoTipo;
                    }
                    else
                    {
                        if (_context.DocumentoTipo.Any())
                        {
                            idDocumentoTipo = (byte)(_context.DocumentoTipo.Max(dt => dt.IdDocumentoTipo) + 1);
                        }
                        else
                        {
                            idDocumentoTipo = 1;
                        }
                        _context.DocumentoTipo.Add(new()
                        {
                            IdDocumentoTipo = idDocumentoTipo,
                            Sigla = value,
                            Nombre = value
                        });
                        _context.SaveChanges();
                        _documentoTipos = _context.DocumentoTipo;
                    }
                }

                // Tipo de nacionalidad
                errorMessageField = "Tipo de nacionalidad";
                value = row[ColumnaNacionalidadTipo].ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    Models.NacionalidadTipo nacionalidadTipo = _nacionalidadTipos.FirstOrDefault(nt => nt.Nombre.Equals(value, StringComparison.CurrentCultureIgnoreCase));
                    if (nacionalidadTipo is not null)
                    {
                        idNacionalidadTipo = nacionalidadTipo.IdNacionalidadTipo;
                    }
                    else
                    {
                        if (MessageBox.Show($"No se eoncontró la nacionalidad '{value}' de la fila número {numeroFila:N0} del archivo '{archivo}'.\n\n¿Desea continuar?", Program.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                        {
                            Cursor = Cursors.Default;
                            return false;
                        }
                        idNacionalidadTipo = (byte)(_context.NacionalidadTipo.Max(nt => nt.IdNacionalidadTipo) + 1);
                        _context.NacionalidadTipo.Add(new()
                        {
                            IdNacionalidadTipo = idNacionalidadTipo,
                            Nombre = value.ToTitleCaseAll()
                        });
                        _context.SaveChanges();
                        _nacionalidadTipos = _context.NacionalidadTipo;
                    }
                }

                // Asigno los datos a la entdiad
                persona.IdPersona = _idPersona;
                persona.Apellido = row[ColumnaApellido].ToString();
                persona.Nombre = row[ColumnaNombre].ToString();
                persona.IdDocumentoTipo = idDocumentoTipo;
                errorMessageField = "Número de documento";
                persona.DocumentoNumero = int.Parse(row[ColumnaDocumentoNumero].ToString());
                errorMessageField = "Fecha de nacimiento";
#pragma warning restore S1854 // Unused assignments should be removed
                if (string.IsNullOrEmpty(row[ColumnaFechaNacimiento].ToString()))
                {
                    persona.FechaNacimiento = null;
                }
                else
                {
                    persona.FechaNacimiento = DateOnly.FromDateTime(DateTime.ParseExact(row[ColumnaFechaNacimiento].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None));
                }
                persona.Genero = row[ColumnaGenero].ToString();
                persona.Domicilio = row[ColumnaDomicilio].ToString();
                persona.Localidad = row[ColumnaLocalidad].ToString();
                errorMessageField = "Código postal";
                if (!string.IsNullOrEmpty(row[ColumnaCodigoPostal].ToString()) && short.TryParse(row[ColumnaCodigoPostal].ToString(), out short codigoPostal))
                {
                    persona.CodigoPostal = codigoPostal;
                }
                else
                {
                    persona.CodigoPostal = null;
                }
                persona.IdNacionalidadTipo = idNacionalidadTipo;
                persona.IdCircuito = _idCircuito;

                _context.Persona.Add(persona);
                _idPersona++;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show($"Error al obtener el valor '{errorMessageField}' de la fila número {numeroFila:N0} del archivo '{archivo}'.\n\nError: {ex.Message}\n\n¿Desea continuar?" + (ex.InnerException is not null ? $"\n{ex.InnerException.Message}" : string.Empty), Program.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                {
                    Cursor = Cursors.Default;
                    return false;
                }
            }
            return true;
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