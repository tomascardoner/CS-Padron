using CardonerSistemas.Framework.Base;
using ExcelDataReader;
using System.Data;
using System.Globalization;

namespace CS_Padron_Importador
{
    public partial class FormMain : Form
    {
        private const byte IdDistrito = 1;
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
        private byte _idSeccion;
        private byte _idCircuito;
        private int _idPersona;
        private IEnumerable<Models.DocumentoTipo> _documentoTipos;
        private IEnumerable<Models.NacionalidadTipo> _nacionalidadTipos;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public FormMain()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
            Models.CSPadronContext.ConnectionString = "Server=localhost;Database=CSPadron;Trusted_Connection=False;User Id=sa;Password=Tai1802Pei;TrustServerCertificate=True";
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
                for (int i = 0; i < CheckedListBoxArchivos.CheckedItems.Count; i++)
                {
                    if (!ImportarArchivo(CheckedListBoxArchivos.CheckedItems[i].ToString()))
                    {
                        return;
                    }
                }
            }
        }

        private bool ImportarArchivo(string archivo)
        {
            Cursor = Cursors.WaitCursor;
            LabelEstado.Text = $"Abriendo el archivo {archivo}....";
            Application.DoEvents();
            try
            {
                using FileStream stream = File.Open(Path.Combine(_folder, archivo), FileMode.Open, FileAccess.Read);
                using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
                DataSet dataSet = reader.AsDataSet();


                ProgressBarArchivo.Value = 0;
                ProgressBarArchivo.Maximum = dataSet.Tables[0].Rows.Count;
                ProgressBarArchivo.Visible = true;

                if (_context is null)
                {
                    _context = new();
                    _documentoTipos = _context.DocumentoTipo;
                    _nacionalidadTipos = _context.NacionalidadTipo;
                    if (_context.Persona.Any())
                    {
                        _idPersona = _context.Persona.Sum(p => p.IdPersona) + 1;
                    }
                    else 
                    {
                        _idPersona = 1;
                    }
                }
                dataSet.Tables[0].Rows.RemoveAt(0);
                int numeroFila = 0;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    numeroFila++;
                    if (!AsignarValoresAPersona(row, numeroFila, new Models.Persona()))
                    {
                        ProgressBarArchivo.Visible = false;
                        Cursor = Cursors.Default;
                        return false;
                    }
                    ProgressBarArchivo.Value++;
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer los datos del archivo {archivo}.\n\nError: {ex.Message}", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return false;
            }
            ProgressBarArchivo.Visible = false;
            Cursor = Cursors.Default;
            return true;
        }

        private bool AsignarValoresAPersona(DataRow row, int numeroFila, Models.Persona persona)
        {
            string errorMessageField = string.Empty;
            string value;
            byte idDocumentoTipo;
            byte idNacionalidadTipo = 0;

            try
            {

                // Código de sección
                errorMessageField = "Código de sección";
                value = row[ColumnaCodigoSeccion].ToString();
                if (byte.TryParse(value, out byte idSeccion) && idSeccion != _idSeccion)
                {
                    Models.Seccion seccion = _context.Seccion.Find(IdDistrito, idSeccion);
                    if (seccion is null)
                    {
                        value = row[ColumnaSeccion].ToString();
                        value = value[(value.IndexOf(CodigoSeparador) + CodigoSeparador.Length)..];
                        _context.Seccion.Add(new()
                        {
                            IdDistrito = IdDistrito,
                            IdSeccion = idSeccion,
                            Nombre = value.ToTitleCaseAll()
                        });
                    }
                    _idSeccion = idSeccion;
                }

                // Código de circuito
                errorMessageField = "Código de circuito";
                value = row[ColumnaCodigoCircuito].ToString();
                if (byte.TryParse(value, out byte idCircuito) && idCircuito != _idCircuito)
                {
                    Models.Circuito circuito = _context.Circuito.Find(IdDistrito, _idSeccion, idCircuito);
                    if (circuito is null)
                    {
                        value = row[ColumnaCircuito].ToString();
                        value = value[(value.IndexOf(CodigoSeparador) + CodigoSeparador.Length)..];
                        _context.Circuito.Add(new()
                        {
                            IdDistrito = IdDistrito,
                            IdSeccion = _idSeccion,
                            IdCircuito = idCircuito,
                            Nombre = value.ToTitleCaseAll()
                        });
                    }
                    _idCircuito = idCircuito;
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
                        idDocumentoTipo = (byte)(_context.DocumentoTipo.Max(dt => dt.IdDocumentoTipo) + 1);
                        _context.DocumentoTipo.Add(new()
                        {
                            IdDocumentoTipo = idDocumentoTipo,
                            Sigla = value,
                            Nombre = value
                        });
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
                        idNacionalidadTipo = (byte)(_context.NacionalidadTipo.Max(nt => nt.IdNacionalidadTipo) + 1);
                        _context.NacionalidadTipo.Add(new()
                        {
                            IdNacionalidadTipo = idNacionalidadTipo,
                            Nombre = value.ToTitleCaseAll()
                        });
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
                persona.IdDistrito = IdDistrito;
                persona.IdSeccion = _idSeccion;
                persona.IdCircuito = _idCircuito;
                _context.Persona.Add(persona);
                _context.SaveChanges();
                _idPersona++;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show($"Error al obtener el valor '{errorMessageField}' de la fila número {numeroFila}.\n\nError: {ex.Message}", Program.Info.Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
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
    }
}