<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DocumentoNumeroLabel As System.Windows.Forms.Label
        Dim ClaseLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ProfesionLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim CircuitoLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim MesaLabel As System.Windows.Forms.Label
        Dim OrdenLabel As System.Windows.Forms.Label
        Dim MesaNombreLabel As System.Windows.Forms.Label
        Dim MesaDireccionLabel As System.Windows.Forms.Label
        Dim MesaLocalidadLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.pnlDetail = New System.Windows.Forms.Panel()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.bngsrcDetail = New System.Windows.Forms.BindingSource(Me.components)
        Me.datsetPadron = New CS_Padron.datsetPadron()
        Me.MesaLocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.bngsrcMesa = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesaDireccionTextBox = New System.Windows.Forms.TextBox()
        Me.MesaNombreTextBox = New System.Windows.Forms.TextBox()
        Me.lblDivisionLine = New System.Windows.Forms.Label()
        Me.OrdenTextBox = New System.Windows.Forms.TextBox()
        Me.MesaTextBox = New System.Windows.Forms.TextBox()
        Me.btnDetailBack = New System.Windows.Forms.Button()
        Me.btnDetailNewSearch = New System.Windows.Forms.Button()
        Me.bngnavDetail = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPrint = New System.Windows.Forms.ToolStripButton()
        Me.DocumentoNumeroTextBox = New System.Windows.Forms.TextBox()
        Me.ClaseTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ProfesionTextBox = New System.Windows.Forms.TextBox()
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentoTipoTextBox = New System.Windows.Forms.TextBox()
        Me.CircuitoTextBox = New System.Windows.Forms.TextBox()
        Me.SexoTextBox = New System.Windows.Forms.TextBox()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.cboboxSearchSexo = New System.Windows.Forms.ComboBox()
        Me.lblSearchSexo = New System.Windows.Forms.Label()
        Me.cboboxSearchNombre = New System.Windows.Forms.ComboBox()
        Me.btnSearchSearch = New System.Windows.Forms.Button()
        Me.txtboxSearchNombre = New System.Windows.Forms.TextBox()
        Me.lblSearchNombre = New System.Windows.Forms.Label()
        Me.txtboxSearchDocumentoNumero = New System.Windows.Forms.TextBox()
        Me.lblSearchDocumentoNumero = New System.Windows.Forms.Label()
        Me.radbtnSearchApellidoNombre = New System.Windows.Forms.RadioButton()
        Me.radbtnSearchDocumento = New System.Windows.Forms.RadioButton()
        Me.lblSearchTitle = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.lblResultCount = New System.Windows.Forms.Label()
        Me.btnResultDetail = New System.Windows.Forms.Button()
        Me.btnResultBack = New System.Windows.Forms.Button()
        Me.lblResultTitle = New System.Windows.Forms.Label()
        Me.datgrdResult = New System.Windows.Forms.DataGridView()
        Me.IDPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Circuito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mesa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bngsrcResult = New System.Windows.Forms.BindingSource(Me.components)
        Me.prnfrmMain = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.tbladpDetail = New CS_Padron.datsetPadronTableAdapters.PadronTableAdapter()
        Me.tbladpResult = New CS_Padron.datsetPadronTableAdapters.PadronTableAdapter()
        Me.tbladpMesa = New CS_Padron.datsetPadronTableAdapters.MesaTableAdapter()
        DocumentoNumeroLabel = New System.Windows.Forms.Label()
        ClaseLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ProfesionLabel = New System.Windows.Forms.Label()
        DomicilioLabel = New System.Windows.Forms.Label()
        CircuitoLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        MesaLabel = New System.Windows.Forms.Label()
        OrdenLabel = New System.Windows.Forms.Label()
        MesaNombreLabel = New System.Windows.Forms.Label()
        MesaDireccionLabel = New System.Windows.Forms.Label()
        MesaLocalidadLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        Me.pnlDetail.SuspendLayout()
        CType(Me.bngsrcDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datsetPadron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bngsrcMesa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bngnavDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bngnavDetail.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.datgrdResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bngsrcResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentoNumeroLabel
        '
        DocumentoNumeroLabel.AutoSize = True
        DocumentoNumeroLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DocumentoNumeroLabel.Location = New System.Drawing.Point(15, 16)
        DocumentoNumeroLabel.Name = "DocumentoNumeroLabel"
        DocumentoNumeroLabel.Size = New System.Drawing.Size(88, 18)
        DocumentoNumeroLabel.TabIndex = 13
        DocumentoNumeroLabel.Text = "Documento:"
        '
        'ClaseLabel
        '
        ClaseLabel.AutoSize = True
        ClaseLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClaseLabel.Location = New System.Drawing.Point(243, 112)
        ClaseLabel.Name = "ClaseLabel"
        ClaseLabel.Size = New System.Drawing.Size(47, 18)
        ClaseLabel.TabIndex = 16
        ClaseLabel.Text = "Clase:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(14, 80)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(65, 18)
        NombreLabel.TabIndex = 20
        NombreLabel.Text = "Nombre:"
        '
        'ProfesionLabel
        '
        ProfesionLabel.AutoSize = True
        ProfesionLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProfesionLabel.Location = New System.Drawing.Point(14, 143)
        ProfesionLabel.Name = "ProfesionLabel"
        ProfesionLabel.Size = New System.Drawing.Size(72, 18)
        ProfesionLabel.TabIndex = 22
        ProfesionLabel.Text = "Profesión:"
        '
        'DomicilioLabel
        '
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DomicilioLabel.Location = New System.Drawing.Point(14, 175)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(67, 18)
        DomicilioLabel.TabIndex = 24
        DomicilioLabel.Text = "Domicilio:"
        '
        'CircuitoLabel
        '
        CircuitoLabel.AutoSize = True
        CircuitoLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CircuitoLabel.Location = New System.Drawing.Point(14, 207)
        CircuitoLabel.Name = "CircuitoLabel"
        CircuitoLabel.Size = New System.Drawing.Size(59, 18)
        CircuitoLabel.TabIndex = 28
        CircuitoLabel.Text = "Circuito:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexoLabel.Location = New System.Drawing.Point(14, 112)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(45, 18)
        SexoLabel.TabIndex = 30
        SexoLabel.Text = "Sexo:"
        '
        'MesaLabel
        '
        MesaLabel.AutoSize = True
        MesaLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MesaLabel.Location = New System.Drawing.Point(214, 207)
        MesaLabel.Name = "MesaLabel"
        MesaLabel.Size = New System.Drawing.Size(48, 18)
        MesaLabel.TabIndex = 47
        MesaLabel.Text = "Mesa:"
        '
        'OrdenLabel
        '
        OrdenLabel.AutoSize = True
        OrdenLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OrdenLabel.Location = New System.Drawing.Point(346, 207)
        OrdenLabel.Name = "OrdenLabel"
        OrdenLabel.Size = New System.Drawing.Size(53, 18)
        OrdenLabel.TabIndex = 49
        OrdenLabel.Text = "Orden:"
        '
        'MesaNombreLabel
        '
        MesaNombreLabel.AutoSize = True
        MesaNombreLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MesaNombreLabel.Location = New System.Drawing.Point(16, 245)
        MesaNombreLabel.Name = "MesaNombreLabel"
        MesaNombreLabel.Size = New System.Drawing.Size(86, 18)
        MesaNombreLabel.TabIndex = 53
        MesaNombreLabel.Text = "Establecim.:"
        '
        'MesaDireccionLabel
        '
        MesaDireccionLabel.AutoSize = True
        MesaDireccionLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MesaDireccionLabel.Location = New System.Drawing.Point(16, 277)
        MesaDireccionLabel.Name = "MesaDireccionLabel"
        MesaDireccionLabel.Size = New System.Drawing.Size(70, 18)
        MesaDireccionLabel.TabIndex = 54
        MesaDireccionLabel.Text = "Dirección:"
        '
        'MesaLocalidadLabel
        '
        MesaLocalidadLabel.AutoSize = True
        MesaLocalidadLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MesaLocalidadLabel.Location = New System.Drawing.Point(18, 309)
        MesaLocalidadLabel.Name = "MesaLocalidadLabel"
        MesaLocalidadLabel.Size = New System.Drawing.Size(71, 18)
        MesaLocalidadLabel.TabIndex = 57
        MesaLocalidadLabel.Text = "Localidad:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.Location = New System.Drawing.Point(15, 48)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(60, 18)
        ApellidoLabel.TabIndex = 58
        ApellidoLabel.Text = "Apellido:"
        '
        'pnlDetail
        '
        Me.pnlDetail.Controls.Add(ApellidoLabel)
        Me.pnlDetail.Controls.Add(Me.ApellidoTextBox)
        Me.pnlDetail.Controls.Add(MesaLocalidadLabel)
        Me.pnlDetail.Controls.Add(Me.MesaLocalidadTextBox)
        Me.pnlDetail.Controls.Add(Me.MesaDireccionTextBox)
        Me.pnlDetail.Controls.Add(MesaDireccionLabel)
        Me.pnlDetail.Controls.Add(MesaNombreLabel)
        Me.pnlDetail.Controls.Add(Me.MesaNombreTextBox)
        Me.pnlDetail.Controls.Add(Me.lblDivisionLine)
        Me.pnlDetail.Controls.Add(OrdenLabel)
        Me.pnlDetail.Controls.Add(Me.OrdenTextBox)
        Me.pnlDetail.Controls.Add(MesaLabel)
        Me.pnlDetail.Controls.Add(Me.MesaTextBox)
        Me.pnlDetail.Controls.Add(Me.btnDetailBack)
        Me.pnlDetail.Controls.Add(Me.btnDetailNewSearch)
        Me.pnlDetail.Controls.Add(Me.bngnavDetail)
        Me.pnlDetail.Controls.Add(DocumentoNumeroLabel)
        Me.pnlDetail.Controls.Add(Me.DocumentoNumeroTextBox)
        Me.pnlDetail.Controls.Add(ClaseLabel)
        Me.pnlDetail.Controls.Add(Me.ClaseTextBox)
        Me.pnlDetail.Controls.Add(NombreLabel)
        Me.pnlDetail.Controls.Add(Me.NombreTextBox)
        Me.pnlDetail.Controls.Add(ProfesionLabel)
        Me.pnlDetail.Controls.Add(Me.ProfesionTextBox)
        Me.pnlDetail.Controls.Add(DomicilioLabel)
        Me.pnlDetail.Controls.Add(Me.DomicilioTextBox)
        Me.pnlDetail.Controls.Add(Me.DocumentoTipoTextBox)
        Me.pnlDetail.Controls.Add(CircuitoLabel)
        Me.pnlDetail.Controls.Add(Me.CircuitoTextBox)
        Me.pnlDetail.Controls.Add(SexoLabel)
        Me.pnlDetail.Controls.Add(Me.SexoTextBox)
        Me.pnlDetail.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDetail.Location = New System.Drawing.Point(12, 12)
        Me.pnlDetail.Name = "pnlDetail"
        Me.pnlDetail.Size = New System.Drawing.Size(530, 387)
        Me.pnlDetail.TabIndex = 12
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcDetail, "Apellido", True))
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(126, 45)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.ReadOnly = True
        Me.ApellidoTextBox.Size = New System.Drawing.Size(385, 26)
        Me.ApellidoTextBox.TabIndex = 59
        Me.ApellidoTextBox.TabStop = False
        '
        'bngsrcDetail
        '
        Me.bngsrcDetail.DataMember = "Padron"
        Me.bngsrcDetail.DataSource = Me.datsetPadron
        Me.bngsrcDetail.Sort = ""
        '
        'datsetPadron
        '
        Me.datsetPadron.DataSetName = "datsetPadron"
        Me.datsetPadron.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MesaLocalidadTextBox
        '
        Me.MesaLocalidadTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MesaLocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcMesa, "Localidad", True))
        Me.MesaLocalidadTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesaLocalidadTextBox.Location = New System.Drawing.Point(128, 306)
        Me.MesaLocalidadTextBox.Name = "MesaLocalidadTextBox"
        Me.MesaLocalidadTextBox.ReadOnly = True
        Me.MesaLocalidadTextBox.Size = New System.Drawing.Size(384, 26)
        Me.MesaLocalidadTextBox.TabIndex = 56
        Me.MesaLocalidadTextBox.TabStop = False
        '
        'bngsrcMesa
        '
        Me.bngsrcMesa.DataMember = "Mesa"
        Me.bngsrcMesa.DataSource = Me.datsetPadron
        Me.bngsrcMesa.Sort = ""
        '
        'MesaDireccionTextBox
        '
        Me.MesaDireccionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MesaDireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcMesa, "Direccion", True))
        Me.MesaDireccionTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesaDireccionTextBox.Location = New System.Drawing.Point(128, 274)
        Me.MesaDireccionTextBox.Name = "MesaDireccionTextBox"
        Me.MesaDireccionTextBox.ReadOnly = True
        Me.MesaDireccionTextBox.Size = New System.Drawing.Size(384, 26)
        Me.MesaDireccionTextBox.TabIndex = 55
        Me.MesaDireccionTextBox.TabStop = False
        '
        'MesaNombreTextBox
        '
        Me.MesaNombreTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MesaNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcMesa, "Nombre", True))
        Me.MesaNombreTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesaNombreTextBox.Location = New System.Drawing.Point(127, 242)
        Me.MesaNombreTextBox.Name = "MesaNombreTextBox"
        Me.MesaNombreTextBox.ReadOnly = True
        Me.MesaNombreTextBox.Size = New System.Drawing.Size(384, 26)
        Me.MesaNombreTextBox.TabIndex = 52
        Me.MesaNombreTextBox.TabStop = False
        '
        'lblDivisionLine
        '
        Me.lblDivisionLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDivisionLine.Location = New System.Drawing.Point(16, 235)
        Me.lblDivisionLine.Name = "lblDivisionLine"
        Me.lblDivisionLine.Size = New System.Drawing.Size(494, 2)
        Me.lblDivisionLine.TabIndex = 51
        '
        'OrdenTextBox
        '
        Me.OrdenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcDetail, "Orden", True))
        Me.OrdenTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdenTextBox.Location = New System.Drawing.Point(411, 204)
        Me.OrdenTextBox.Name = "OrdenTextBox"
        Me.OrdenTextBox.ReadOnly = True
        Me.OrdenTextBox.Size = New System.Drawing.Size(46, 26)
        Me.OrdenTextBox.TabIndex = 50
        Me.OrdenTextBox.TabStop = False
        '
        'MesaTextBox
        '
        Me.MesaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcDetail, "Mesa", True))
        Me.MesaTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesaTextBox.Location = New System.Drawing.Point(279, 204)
        Me.MesaTextBox.Name = "MesaTextBox"
        Me.MesaTextBox.ReadOnly = True
        Me.MesaTextBox.Size = New System.Drawing.Size(46, 26)
        Me.MesaTextBox.TabIndex = 48
        Me.MesaTextBox.TabStop = False
        '
        'btnDetailBack
        '
        Me.btnDetailBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetailBack.Image = CType(resources.GetObject("btnDetailBack.Image"), System.Drawing.Image)
        Me.btnDetailBack.Location = New System.Drawing.Point(306, 344)
        Me.btnDetailBack.Name = "btnDetailBack"
        Me.btnDetailBack.Size = New System.Drawing.Size(109, 43)
        Me.btnDetailBack.TabIndex = 46
        Me.btnDetailBack.Text = "Volver"
        Me.btnDetailBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDetailBack.UseVisualStyleBackColor = True
        '
        'btnDetailNewSearch
        '
        Me.btnDetailNewSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetailNewSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDetailNewSearch.Image = CType(resources.GetObject("btnDetailNewSearch.Image"), System.Drawing.Image)
        Me.btnDetailNewSearch.Location = New System.Drawing.Point(421, 344)
        Me.btnDetailNewSearch.Name = "btnDetailNewSearch"
        Me.btnDetailNewSearch.Size = New System.Drawing.Size(109, 43)
        Me.btnDetailNewSearch.TabIndex = 45
        Me.btnDetailNewSearch.Text = "Nueva"
        Me.btnDetailNewSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDetailNewSearch.UseVisualStyleBackColor = True
        '
        'bngnavDetail
        '
        Me.bngnavDetail.AddNewItem = Nothing
        Me.bngnavDetail.BindingSource = Me.bngsrcDetail
        Me.bngnavDetail.CountItem = Me.BindingNavigatorCountItem
        Me.bngnavDetail.CountItemFormat = "de {0}"
        Me.bngnavDetail.DeleteItem = Nothing
        Me.bngnavDetail.Dock = System.Windows.Forms.DockStyle.None
        Me.bngnavDetail.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bngnavDetail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorPrint})
        Me.bngnavDetail.Location = New System.Drawing.Point(0, 365)
        Me.bngnavDetail.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bngnavDetail.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bngnavDetail.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bngnavDetail.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bngnavDetail.Name = "bngnavDetail"
        Me.bngnavDetail.PositionItem = Me.BindingNavigatorPositionItem
        Me.bngnavDetail.Size = New System.Drawing.Size(232, 25)
        Me.bngnavDetail.TabIndex = 32
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Cantidad Total de Personas"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        Me.BindingNavigatorMoveFirstItem.ToolTipText = "Ir al primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        Me.BindingNavigatorMovePreviousItem.ToolTipText = "Ir al anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.MaxLength = 5
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        Me.BindingNavigatorMoveNextItem.ToolTipText = "Ir al siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.ToolTipText = "Ir al último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPrint
        '
        Me.BindingNavigatorPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorPrint.Image = CType(resources.GetObject("BindingNavigatorPrint.Image"), System.Drawing.Image)
        Me.BindingNavigatorPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorPrint.Name = "BindingNavigatorPrint"
        Me.BindingNavigatorPrint.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorPrint.ToolTipText = "Imprimir ventana"
        '
        'DocumentoNumeroTextBox
        '
        Me.DocumentoNumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcDetail, "DocumentoNumero", True))
        Me.DocumentoNumeroTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentoNumeroTextBox.Location = New System.Drawing.Point(205, 13)
        Me.DocumentoNumeroTextBox.Name = "DocumentoNumeroTextBox"
        Me.DocumentoNumeroTextBox.ReadOnly = True
        Me.DocumentoNumeroTextBox.Size = New System.Drawing.Size(97, 26)
        Me.DocumentoNumeroTextBox.TabIndex = 15
        Me.DocumentoNumeroTextBox.TabStop = False
        '
        'ClaseTextBox
        '
        Me.ClaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcDetail, "Clase", True))
        Me.ClaseTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClaseTextBox.Location = New System.Drawing.Point(302, 109)
        Me.ClaseTextBox.Name = "ClaseTextBox"
        Me.ClaseTextBox.ReadOnly = True
        Me.ClaseTextBox.Size = New System.Drawing.Size(57, 26)
        Me.ClaseTextBox.TabIndex = 17
        Me.ClaseTextBox.TabStop = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcDetail, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(125, 77)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(385, 26)
        Me.NombreTextBox.TabIndex = 21
        Me.NombreTextBox.TabStop = False
        '
        'ProfesionTextBox
        '
        Me.ProfesionTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfesionTextBox.Location = New System.Drawing.Point(125, 140)
        Me.ProfesionTextBox.Name = "ProfesionTextBox"
        Me.ProfesionTextBox.ReadOnly = True
        Me.ProfesionTextBox.Size = New System.Drawing.Size(104, 26)
        Me.ProfesionTextBox.TabIndex = 23
        Me.ProfesionTextBox.TabStop = False
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DomicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcDetail, "Domicilio", True))
        Me.DomicilioTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomicilioTextBox.Location = New System.Drawing.Point(125, 172)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.ReadOnly = True
        Me.DomicilioTextBox.Size = New System.Drawing.Size(385, 26)
        Me.DomicilioTextBox.TabIndex = 25
        Me.DomicilioTextBox.TabStop = False
        '
        'DocumentoTipoTextBox
        '
        Me.DocumentoTipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcDetail, "DocumentoTipo", True))
        Me.DocumentoTipoTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentoTipoTextBox.Location = New System.Drawing.Point(126, 13)
        Me.DocumentoTipoTextBox.Name = "DocumentoTipoTextBox"
        Me.DocumentoTipoTextBox.ReadOnly = True
        Me.DocumentoTipoTextBox.Size = New System.Drawing.Size(73, 26)
        Me.DocumentoTipoTextBox.TabIndex = 14
        Me.DocumentoTipoTextBox.TabStop = False
        '
        'CircuitoTextBox
        '
        Me.CircuitoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcDetail, "Circuito", True))
        Me.CircuitoTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircuitoTextBox.Location = New System.Drawing.Point(125, 204)
        Me.CircuitoTextBox.Name = "CircuitoTextBox"
        Me.CircuitoTextBox.ReadOnly = True
        Me.CircuitoTextBox.Size = New System.Drawing.Size(63, 26)
        Me.CircuitoTextBox.TabIndex = 29
        Me.CircuitoTextBox.TabStop = False
        '
        'SexoTextBox
        '
        Me.SexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bngsrcDetail, "Sexo", True))
        Me.SexoTextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexoTextBox.Location = New System.Drawing.Point(125, 109)
        Me.SexoTextBox.Name = "SexoTextBox"
        Me.SexoTextBox.ReadOnly = True
        Me.SexoTextBox.Size = New System.Drawing.Size(21, 26)
        Me.SexoTextBox.TabIndex = 31
        Me.SexoTextBox.TabStop = False
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.cboboxSearchSexo)
        Me.pnlSearch.Controls.Add(Me.lblSearchSexo)
        Me.pnlSearch.Controls.Add(Me.cboboxSearchNombre)
        Me.pnlSearch.Controls.Add(Me.btnSearchSearch)
        Me.pnlSearch.Controls.Add(Me.txtboxSearchNombre)
        Me.pnlSearch.Controls.Add(Me.lblSearchNombre)
        Me.pnlSearch.Controls.Add(Me.txtboxSearchDocumentoNumero)
        Me.pnlSearch.Controls.Add(Me.lblSearchDocumentoNumero)
        Me.pnlSearch.Controls.Add(Me.radbtnSearchApellidoNombre)
        Me.pnlSearch.Controls.Add(Me.radbtnSearchDocumento)
        Me.pnlSearch.Controls.Add(Me.lblSearchTitle)
        Me.pnlSearch.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSearch.Location = New System.Drawing.Point(12, 12)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(530, 387)
        Me.pnlSearch.TabIndex = 0
        '
        'cboboxSearchSexo
        '
        Me.cboboxSearchSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboboxSearchSexo.FormattingEnabled = True
        Me.cboboxSearchSexo.Items.AddRange(New Object() {"« No especifica »", "Femenino", "Masculino"})
        Me.cboboxSearchSexo.Location = New System.Drawing.Point(88, 253)
        Me.cboboxSearchSexo.Name = "cboboxSearchSexo"
        Me.cboboxSearchSexo.Size = New System.Drawing.Size(143, 26)
        Me.cboboxSearchSexo.TabIndex = 13
        '
        'lblSearchSexo
        '
        Me.lblSearchSexo.AutoSize = True
        Me.lblSearchSexo.Location = New System.Drawing.Point(22, 256)
        Me.lblSearchSexo.Name = "lblSearchSexo"
        Me.lblSearchSexo.Size = New System.Drawing.Size(45, 18)
        Me.lblSearchSexo.TabIndex = 12
        Me.lblSearchSexo.Text = "Sexo:"
        '
        'cboboxSearchNombre
        '
        Me.cboboxSearchNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboboxSearchNombre.FormattingEnabled = True
        Me.cboboxSearchNombre.Items.AddRange(New Object() {"sea exactamente igual a:", "comience con:", "contenga en cualquier ubicación:"})
        Me.cboboxSearchNombre.Location = New System.Drawing.Point(88, 178)
        Me.cboboxSearchNombre.Name = "cboboxSearchNombre"
        Me.cboboxSearchNombre.Size = New System.Drawing.Size(235, 26)
        Me.cboboxSearchNombre.TabIndex = 9
        '
        'btnSearchSearch
        '
        Me.btnSearchSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchSearch.Image = CType(resources.GetObject("btnSearchSearch.Image"), System.Drawing.Image)
        Me.btnSearchSearch.Location = New System.Drawing.Point(421, 344)
        Me.btnSearchSearch.Name = "btnSearchSearch"
        Me.btnSearchSearch.Size = New System.Drawing.Size(109, 43)
        Me.btnSearchSearch.TabIndex = 11
        Me.btnSearchSearch.Text = "Buscar"
        Me.btnSearchSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchSearch.UseVisualStyleBackColor = True
        '
        'txtboxSearchNombre
        '
        Me.txtboxSearchNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxSearchNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtboxSearchNombre.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxSearchNombre.Location = New System.Drawing.Point(88, 210)
        Me.txtboxSearchNombre.MaxLength = 29
        Me.txtboxSearchNombre.Name = "txtboxSearchNombre"
        Me.txtboxSearchNombre.Size = New System.Drawing.Size(423, 26)
        Me.txtboxSearchNombre.TabIndex = 10
        '
        'lblSearchNombre
        '
        Me.lblSearchNombre.AutoSize = True
        Me.lblSearchNombre.Location = New System.Drawing.Point(22, 181)
        Me.lblSearchNombre.Name = "lblSearchNombre"
        Me.lblSearchNombre.Size = New System.Drawing.Size(65, 18)
        Me.lblSearchNombre.TabIndex = 8
        Me.lblSearchNombre.Text = "Nombre:"
        '
        'txtboxSearchDocumentoNumero
        '
        Me.txtboxSearchDocumentoNumero.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxSearchDocumentoNumero.Location = New System.Drawing.Point(159, 82)
        Me.txtboxSearchDocumentoNumero.MaxLength = 8
        Me.txtboxSearchDocumentoNumero.Name = "txtboxSearchDocumentoNumero"
        Me.txtboxSearchDocumentoNumero.Size = New System.Drawing.Size(102, 26)
        Me.txtboxSearchDocumentoNumero.TabIndex = 3
        Me.txtboxSearchDocumentoNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSearchDocumentoNumero
        '
        Me.lblSearchDocumentoNumero.AutoSize = True
        Me.lblSearchDocumentoNumero.Location = New System.Drawing.Point(22, 85)
        Me.lblSearchDocumentoNumero.Name = "lblSearchDocumentoNumero"
        Me.lblSearchDocumentoNumero.Size = New System.Drawing.Size(131, 18)
        Me.lblSearchDocumentoNumero.TabIndex = 2
        Me.lblSearchDocumentoNumero.Text = "Nº de Documento:"
        '
        'radbtnSearchApellidoNombre
        '
        Me.radbtnSearchApellidoNombre.AutoSize = True
        Me.radbtnSearchApellidoNombre.Location = New System.Drawing.Point(3, 140)
        Me.radbtnSearchApellidoNombre.Name = "radbtnSearchApellidoNombre"
        Me.radbtnSearchApellidoNombre.Size = New System.Drawing.Size(158, 22)
        Me.radbtnSearchApellidoNombre.TabIndex = 4
        Me.radbtnSearchApellidoNombre.Text = "Buscar por Nombre:"
        Me.radbtnSearchApellidoNombre.UseVisualStyleBackColor = True
        '
        'radbtnSearchDocumento
        '
        Me.radbtnSearchDocumento.AutoSize = True
        Me.radbtnSearchDocumento.Location = New System.Drawing.Point(3, 49)
        Me.radbtnSearchDocumento.Name = "radbtnSearchDocumento"
        Me.radbtnSearchDocumento.Size = New System.Drawing.Size(181, 22)
        Me.radbtnSearchDocumento.TabIndex = 1
        Me.radbtnSearchDocumento.Text = "Buscar por Documento:"
        Me.radbtnSearchDocumento.UseVisualStyleBackColor = True
        '
        'lblSearchTitle
        '
        Me.lblSearchTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSearchTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchTitle.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblSearchTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblSearchTitle.Name = "lblSearchTitle"
        Me.lblSearchTitle.Size = New System.Drawing.Size(530, 29)
        Me.lblSearchTitle.TabIndex = 1
        Me.lblSearchTitle.Text = "Opciones de Búsqueda"
        Me.lblSearchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCopyright
        '
        Me.lblCopyright.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(12, 402)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(530, 19)
        Me.lblCopyright.TabIndex = 12
        Me.lblCopyright.Text = "Copyright"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.lblResultCount)
        Me.pnlGrid.Controls.Add(Me.btnResultDetail)
        Me.pnlGrid.Controls.Add(Me.btnResultBack)
        Me.pnlGrid.Controls.Add(Me.lblResultTitle)
        Me.pnlGrid.Controls.Add(Me.datgrdResult)
        Me.pnlGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGrid.Location = New System.Drawing.Point(12, 12)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(530, 387)
        Me.pnlGrid.TabIndex = 13
        Me.pnlGrid.Visible = False
        '
        'lblResultCount
        '
        Me.lblResultCount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblResultCount.Location = New System.Drawing.Point(18, 344)
        Me.lblResultCount.Name = "lblResultCount"
        Me.lblResultCount.Size = New System.Drawing.Size(229, 21)
        Me.lblResultCount.TabIndex = 49
        Me.lblResultCount.Text = "{0} coincidencias."
        '
        'btnResultDetail
        '
        Me.btnResultDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResultDetail.Image = CType(resources.GetObject("btnResultDetail.Image"), System.Drawing.Image)
        Me.btnResultDetail.Location = New System.Drawing.Point(421, 344)
        Me.btnResultDetail.Name = "btnResultDetail"
        Me.btnResultDetail.Size = New System.Drawing.Size(109, 43)
        Me.btnResultDetail.TabIndex = 48
        Me.btnResultDetail.Text = "Detalles"
        Me.btnResultDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResultDetail.UseVisualStyleBackColor = True
        '
        'btnResultBack
        '
        Me.btnResultBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResultBack.Image = CType(resources.GetObject("btnResultBack.Image"), System.Drawing.Image)
        Me.btnResultBack.Location = New System.Drawing.Point(308, 344)
        Me.btnResultBack.Name = "btnResultBack"
        Me.btnResultBack.Size = New System.Drawing.Size(109, 43)
        Me.btnResultBack.TabIndex = 47
        Me.btnResultBack.Text = "Volver"
        Me.btnResultBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResultBack.UseVisualStyleBackColor = True
        '
        'lblResultTitle
        '
        Me.lblResultTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResultTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblResultTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblResultTitle.Name = "lblResultTitle"
        Me.lblResultTitle.Size = New System.Drawing.Size(530, 29)
        Me.lblResultTitle.TabIndex = 2
        Me.lblResultTitle.Text = "Resultados de la Búsqueda"
        Me.lblResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'datgrdResult
        '
        Me.datgrdResult.AllowUserToAddRows = False
        Me.datgrdResult.AllowUserToDeleteRows = False
        Me.datgrdResult.AllowUserToResizeRows = False
        Me.datgrdResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datgrdResult.AutoGenerateColumns = False
        Me.datgrdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datgrdResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPersona, Me.Apellido, Me.Nombre, Me.DocumentoTipo, Me.DocumentoNumero, Me.Clase, Me.Domicilio, Me.Circuito, Me.Mesa, Me.Orden})
        Me.datgrdResult.DataSource = Me.bngsrcResult
        Me.datgrdResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datgrdResult.Location = New System.Drawing.Point(18, 35)
        Me.datgrdResult.Name = "datgrdResult"
        Me.datgrdResult.ReadOnly = True
        Me.datgrdResult.RowHeadersVisible = False
        Me.datgrdResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datgrdResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datgrdResult.ShowEditingIcon = False
        Me.datgrdResult.Size = New System.Drawing.Size(494, 299)
        Me.datgrdResult.TabIndex = 0
        '
        'IDPersona
        '
        Me.IDPersona.DataPropertyName = "IDPersona"
        Me.IDPersona.HeaderText = "IDPersona"
        Me.IDPersona.Name = "IDPersona"
        Me.IDPersona.ReadOnly = True
        Me.IDPersona.Visible = False
        '
        'Apellido
        '
        Me.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Apellido.DataPropertyName = "Apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 84
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 87
        '
        'DocumentoTipo
        '
        Me.DocumentoTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DocumentoTipo.DataPropertyName = "DocumentoTipo"
        Me.DocumentoTipo.HeaderText = "Tipo de Doc."
        Me.DocumentoTipo.Name = "DocumentoTipo"
        Me.DocumentoTipo.ReadOnly = True
        Me.DocumentoTipo.Width = 118
        '
        'DocumentoNumero
        '
        Me.DocumentoNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DocumentoNumero.DataPropertyName = "DocumentoNumero"
        Me.DocumentoNumero.HeaderText = "Nº Documento"
        Me.DocumentoNumero.Name = "DocumentoNumero"
        Me.DocumentoNumero.ReadOnly = True
        Me.DocumentoNumero.Width = 131
        '
        'Clase
        '
        Me.Clase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Clase.DataPropertyName = "Clase"
        Me.Clase.HeaderText = "Clase"
        Me.Clase.Name = "Clase"
        Me.Clase.ReadOnly = True
        Me.Clase.Width = 71
        '
        'Domicilio
        '
        Me.Domicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Domicilio.DataPropertyName = "Domicilio"
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.ReadOnly = True
        Me.Domicilio.Width = 95
        '
        'Circuito
        '
        Me.Circuito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Circuito.DataPropertyName = "Circuito"
        Me.Circuito.HeaderText = "Circuito"
        Me.Circuito.Name = "Circuito"
        Me.Circuito.ReadOnly = True
        Me.Circuito.Width = 84
        '
        'Mesa
        '
        Me.Mesa.DataPropertyName = "Mesa"
        Me.Mesa.HeaderText = "Mesa"
        Me.Mesa.Name = "Mesa"
        Me.Mesa.ReadOnly = True
        '
        'Orden
        '
        Me.Orden.HeaderText = "Orden"
        Me.Orden.Name = "Orden"
        Me.Orden.ReadOnly = True
        '
        'bngsrcResult
        '
        Me.bngsrcResult.DataMember = "Padron"
        Me.bngsrcResult.DataSource = Me.datsetPadron
        Me.bngsrcResult.Sort = ""
        '
        'prnfrmMain
        '
        Me.prnfrmMain.DocumentName = "document"
        Me.prnfrmMain.Form = Me
        Me.prnfrmMain.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.prnfrmMain.PrinterSettings = CType(resources.GetObject("prnfrmMain.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.prnfrmMain.PrintFileName = Nothing
        '
        'tbladpDetail
        '
        Me.tbladpDetail.ClearBeforeFill = True
        '
        'tbladpResult
        '
        Me.tbladpResult.ClearBeforeFill = True
        '
        'tbladpMesa
        '
        Me.tbladpMesa.ClearBeforeFill = True
        '
        'formMain
        '
        Me.AcceptButton = Me.btnSearchSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnDetailNewSearch
        Me.ClientSize = New System.Drawing.Size(555, 426)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlDetail)
        Me.Controls.Add(Me.lblCopyright)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ApplicationTitle"
        Me.pnlDetail.ResumeLayout(False)
        Me.pnlDetail.PerformLayout()
        CType(Me.bngsrcDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datsetPadron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bngsrcMesa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bngnavDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bngnavDetail.ResumeLayout(False)
        Me.bngnavDetail.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.datgrdResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bngsrcResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datsetPadron As CS_Padron.datsetPadron
    Friend WithEvents bngsrcDetail As System.Windows.Forms.BindingSource
    Friend WithEvents pnlDetail As System.Windows.Forms.Panel
    Friend WithEvents bngnavDetail As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DocumentoNumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfesionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DomicilioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DocumentoTipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CircuitoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents lblSearchTitle As System.Windows.Forms.Label
    Friend WithEvents radbtnSearchApellidoNombre As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnSearchDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents txtboxSearchDocumentoNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtboxSearchNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchNombre As System.Windows.Forms.Label
    Friend WithEvents btnSearchSearch As System.Windows.Forms.Button
    Friend WithEvents cboboxSearchNombre As System.Windows.Forms.ComboBox
    Friend WithEvents btnDetailBack As System.Windows.Forms.Button
    Friend WithEvents btnDetailNewSearch As System.Windows.Forms.Button
    Friend WithEvents tbladpDetail As CS_Padron.datsetPadronTableAdapters.PadronTableAdapter
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblSearchSexo As System.Windows.Forms.Label
    Friend WithEvents cboboxSearchSexo As System.Windows.Forms.ComboBox
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents lblResultTitle As System.Windows.Forms.Label
    Friend WithEvents datgrdResult As System.Windows.Forms.DataGridView
    Friend WithEvents btnResultBack As System.Windows.Forms.Button
    Friend WithEvents btnResultDetail As System.Windows.Forms.Button
    Friend WithEvents DocumentoTipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bngsrcResult As System.Windows.Forms.BindingSource
    Friend WithEvents tbladpResult As CS_Padron.datsetPadronTableAdapters.PadronTableAdapter
    Friend WithEvents lblResultCount As System.Windows.Forms.Label
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnalfabetoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AfiliadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents prnfrmMain As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents BindingNavigatorPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblSearchDocumentoNumero As System.Windows.Forms.Label
    Friend WithEvents MesaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrdenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblDivisionLine As System.Windows.Forms.Label
    Friend WithEvents MesaNombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MesaDireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MesaLocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tbladpMesa As CS_Padron.datsetPadronTableAdapters.MesaTableAdapter
    Friend WithEvents bngsrcMesa As System.Windows.Forms.BindingSource
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDPersona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentoTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentoNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Circuito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mesa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Orden As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
