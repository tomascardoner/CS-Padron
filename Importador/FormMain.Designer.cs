namespace CS_Padron_Importador
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableLayoutPanelMain = new TableLayoutPanel();
            TableLayoutPanelCarpeta = new TableLayoutPanel();
            LabelCarpeta = new Label();
            TextBoxCarpeta = new TextBox();
            ButtonExaminar = new Button();
            ButtonBuscar = new Button();
            CheckedListBoxArchivos = new CheckedListBox();
            TableLayoutPanelSeleccionar = new TableLayoutPanel();
            ButtonSeleccionarTodos = new Button();
            ButtonSeleccionarNinguno = new Button();
            TableLayoutPanelIniciar = new TableLayoutPanel();
            LabelOptimizacion = new Label();
            RadioButtonOptimizacionMaxima = new RadioButton();
            RadioButtonOptimizacionIntermedia = new RadioButton();
            RadioButtonOptimizacionNinguna = new RadioButton();
            ButtonIniciar = new Button();
            ProgressBarArchivo = new ProgressBar();
            LabelEstado = new Label();
            TableLayoutPanelMain.SuspendLayout();
            TableLayoutPanelCarpeta.SuspendLayout();
            TableLayoutPanelSeleccionar.SuspendLayout();
            TableLayoutPanelIniciar.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.AutoSize = true;
            TableLayoutPanelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelMain.ColumnCount = 1;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.Controls.Add(TableLayoutPanelCarpeta, 0, 0);
            TableLayoutPanelMain.Controls.Add(CheckedListBoxArchivos, 0, 1);
            TableLayoutPanelMain.Controls.Add(TableLayoutPanelSeleccionar, 0, 2);
            TableLayoutPanelMain.Controls.Add(TableLayoutPanelIniciar, 0, 3);
            TableLayoutPanelMain.Controls.Add(ProgressBarArchivo, 0, 4);
            TableLayoutPanelMain.Controls.Add(LabelEstado, 0, 5);
            TableLayoutPanelMain.Dock = DockStyle.Fill;
            TableLayoutPanelMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelMain.Location = new Point(0, 0);
            TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            TableLayoutPanelMain.RowCount = 6;
            TableLayoutPanelMain.RowStyles.Add(new RowStyle());
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle());
            TableLayoutPanelMain.RowStyles.Add(new RowStyle());
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            TableLayoutPanelMain.Size = new Size(1005, 501);
            TableLayoutPanelMain.TabIndex = 0;
            // 
            // TableLayoutPanelCarpeta
            // 
            TableLayoutPanelCarpeta.AutoSize = true;
            TableLayoutPanelCarpeta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelCarpeta.ColumnCount = 4;
            TableLayoutPanelCarpeta.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelCarpeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelCarpeta.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelCarpeta.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelCarpeta.Controls.Add(LabelCarpeta, 0, 0);
            TableLayoutPanelCarpeta.Controls.Add(TextBoxCarpeta, 1, 0);
            TableLayoutPanelCarpeta.Controls.Add(ButtonExaminar, 2, 0);
            TableLayoutPanelCarpeta.Controls.Add(ButtonBuscar, 3, 0);
            TableLayoutPanelCarpeta.Dock = DockStyle.Fill;
            TableLayoutPanelCarpeta.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelCarpeta.Location = new Point(3, 3);
            TableLayoutPanelCarpeta.Name = "TableLayoutPanelCarpeta";
            TableLayoutPanelCarpeta.RowCount = 1;
            TableLayoutPanelCarpeta.RowStyles.Add(new RowStyle());
            TableLayoutPanelCarpeta.Size = new Size(999, 36);
            TableLayoutPanelCarpeta.TabIndex = 0;
            // 
            // LabelCarpeta
            // 
            LabelCarpeta.AutoSize = true;
            LabelCarpeta.Dock = DockStyle.Fill;
            LabelCarpeta.Location = new Point(3, 0);
            LabelCarpeta.Name = "LabelCarpeta";
            LabelCarpeta.Size = new Size(64, 36);
            LabelCarpeta.TabIndex = 0;
            LabelCarpeta.Text = "Carpeta:";
            LabelCarpeta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxCarpeta
            // 
            TextBoxCarpeta.Dock = DockStyle.Fill;
            TextBoxCarpeta.Location = new Point(73, 4);
            TextBoxCarpeta.Margin = new Padding(3, 4, 3, 3);
            TextBoxCarpeta.MaxLength = 500;
            TextBoxCarpeta.Name = "TextBoxCarpeta";
            TextBoxCarpeta.Size = new Size(763, 27);
            TextBoxCarpeta.TabIndex = 1;
            // 
            // ButtonExaminar
            // 
            ButtonExaminar.AutoSize = true;
            ButtonExaminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonExaminar.Location = new Point(842, 3);
            ButtonExaminar.Name = "ButtonExaminar";
            ButtonExaminar.Size = new Size(28, 30);
            ButtonExaminar.TabIndex = 2;
            ButtonExaminar.Text = "...";
            ButtonExaminar.UseVisualStyleBackColor = true;
            ButtonExaminar.Click += ButtonExaminar_Click;
            // 
            // ButtonBuscar
            // 
            ButtonBuscar.AutoSize = true;
            ButtonBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonBuscar.Dock = DockStyle.Fill;
            ButtonBuscar.Location = new Point(876, 3);
            ButtonBuscar.Name = "ButtonBuscar";
            ButtonBuscar.Size = new Size(120, 30);
            ButtonBuscar.TabIndex = 3;
            ButtonBuscar.Text = "Buscar archivos";
            ButtonBuscar.UseVisualStyleBackColor = true;
            ButtonBuscar.Click += ButtonBuscar_Click;
            // 
            // CheckedListBoxArchivos
            // 
            CheckedListBoxArchivos.CheckOnClick = true;
            CheckedListBoxArchivos.ColumnWidth = 400;
            CheckedListBoxArchivos.Dock = DockStyle.Fill;
            CheckedListBoxArchivos.FormattingEnabled = true;
            CheckedListBoxArchivos.Location = new Point(3, 45);
            CheckedListBoxArchivos.MultiColumn = true;
            CheckedListBoxArchivos.Name = "CheckedListBoxArchivos";
            CheckedListBoxArchivos.Size = new Size(999, 289);
            CheckedListBoxArchivos.TabIndex = 1;
            // 
            // TableLayoutPanelSeleccionar
            // 
            TableLayoutPanelSeleccionar.AutoSize = true;
            TableLayoutPanelSeleccionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelSeleccionar.ColumnCount = 3;
            TableLayoutPanelSeleccionar.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelSeleccionar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelSeleccionar.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelSeleccionar.Controls.Add(ButtonSeleccionarTodos, 0, 0);
            TableLayoutPanelSeleccionar.Controls.Add(ButtonSeleccionarNinguno, 2, 0);
            TableLayoutPanelSeleccionar.Dock = DockStyle.Fill;
            TableLayoutPanelSeleccionar.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelSeleccionar.Location = new Point(3, 340);
            TableLayoutPanelSeleccionar.Name = "TableLayoutPanelSeleccionar";
            TableLayoutPanelSeleccionar.RowCount = 1;
            TableLayoutPanelSeleccionar.RowStyles.Add(new RowStyle());
            TableLayoutPanelSeleccionar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSeleccionar.Size = new Size(999, 36);
            TableLayoutPanelSeleccionar.TabIndex = 2;
            // 
            // ButtonSeleccionarTodos
            // 
            ButtonSeleccionarTodos.AutoSize = true;
            ButtonSeleccionarTodos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSeleccionarTodos.Dock = DockStyle.Fill;
            ButtonSeleccionarTodos.Location = new Point(3, 3);
            ButtonSeleccionarTodos.Name = "ButtonSeleccionarTodos";
            ButtonSeleccionarTodos.Size = new Size(137, 30);
            ButtonSeleccionarTodos.TabIndex = 0;
            ButtonSeleccionarTodos.Text = "Seleccionar todos";
            ButtonSeleccionarTodos.UseVisualStyleBackColor = true;
            ButtonSeleccionarTodos.Click += ButtonSeleccionarTodos_Click;
            // 
            // ButtonSeleccionarNinguno
            // 
            ButtonSeleccionarNinguno.AutoSize = true;
            ButtonSeleccionarNinguno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSeleccionarNinguno.Dock = DockStyle.Fill;
            ButtonSeleccionarNinguno.Location = new Point(843, 3);
            ButtonSeleccionarNinguno.Name = "ButtonSeleccionarNinguno";
            ButtonSeleccionarNinguno.Size = new Size(153, 30);
            ButtonSeleccionarNinguno.TabIndex = 1;
            ButtonSeleccionarNinguno.Text = "Seleccionar ninguno";
            ButtonSeleccionarNinguno.UseVisualStyleBackColor = true;
            ButtonSeleccionarNinguno.Click += ButtonSeleccionarNinguno_Click;
            // 
            // TableLayoutPanelIniciar
            // 
            TableLayoutPanelIniciar.AutoSize = true;
            TableLayoutPanelIniciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelIniciar.ColumnCount = 5;
            TableLayoutPanelIniciar.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelIniciar.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelIniciar.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelIniciar.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanelIniciar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelIniciar.Controls.Add(LabelOptimizacion, 0, 0);
            TableLayoutPanelIniciar.Controls.Add(RadioButtonOptimizacionMaxima, 1, 0);
            TableLayoutPanelIniciar.Controls.Add(RadioButtonOptimizacionIntermedia, 2, 0);
            TableLayoutPanelIniciar.Controls.Add(RadioButtonOptimizacionNinguna, 3, 0);
            TableLayoutPanelIniciar.Controls.Add(ButtonIniciar, 4, 0);
            TableLayoutPanelIniciar.Dock = DockStyle.Fill;
            TableLayoutPanelIniciar.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableLayoutPanelIniciar.Location = new Point(3, 382);
            TableLayoutPanelIniciar.Name = "TableLayoutPanelIniciar";
            TableLayoutPanelIniciar.RowCount = 1;
            TableLayoutPanelIniciar.RowStyles.Add(new RowStyle());
            TableLayoutPanelIniciar.Size = new Size(999, 36);
            TableLayoutPanelIniciar.TabIndex = 1;
            // 
            // LabelOptimizacion
            // 
            LabelOptimizacion.AutoSize = true;
            LabelOptimizacion.Dock = DockStyle.Fill;
            LabelOptimizacion.Location = new Point(3, 0);
            LabelOptimizacion.Name = "LabelOptimizacion";
            LabelOptimizacion.Size = new Size(101, 36);
            LabelOptimizacion.TabIndex = 7;
            LabelOptimizacion.Text = "Optimización:";
            LabelOptimizacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RadioButtonOptimizacionMaxima
            // 
            RadioButtonOptimizacionMaxima.AutoSize = true;
            RadioButtonOptimizacionMaxima.Checked = true;
            RadioButtonOptimizacionMaxima.Dock = DockStyle.Fill;
            RadioButtonOptimizacionMaxima.Location = new Point(110, 3);
            RadioButtonOptimizacionMaxima.Name = "RadioButtonOptimizacionMaxima";
            RadioButtonOptimizacionMaxima.Size = new Size(231, 30);
            RadioButtonOptimizacionMaxima.TabIndex = 4;
            RadioButtonOptimizacionMaxima.TabStop = true;
            RadioButtonOptimizacionMaxima.Text = "Máxima (BulkInsertOptimized)";
            RadioButtonOptimizacionMaxima.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOptimizacionIntermedia
            // 
            RadioButtonOptimizacionIntermedia.AutoSize = true;
            RadioButtonOptimizacionIntermedia.Dock = DockStyle.Fill;
            RadioButtonOptimizacionIntermedia.Location = new Point(347, 3);
            RadioButtonOptimizacionIntermedia.Name = "RadioButtonOptimizacionIntermedia";
            RadioButtonOptimizacionIntermedia.Size = new Size(231, 30);
            RadioButtonOptimizacionIntermedia.TabIndex = 5;
            RadioButtonOptimizacionIntermedia.TabStop = true;
            RadioButtonOptimizacionIntermedia.Text = "Intermedia (BulkSaveChanges)";
            RadioButtonOptimizacionIntermedia.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOptimizacionNinguna
            // 
            RadioButtonOptimizacionNinguna.AutoSize = true;
            RadioButtonOptimizacionNinguna.Dock = DockStyle.Fill;
            RadioButtonOptimizacionNinguna.Location = new Point(584, 3);
            RadioButtonOptimizacionNinguna.Name = "RadioButtonOptimizacionNinguna";
            RadioButtonOptimizacionNinguna.Size = new Size(86, 30);
            RadioButtonOptimizacionNinguna.TabIndex = 6;
            RadioButtonOptimizacionNinguna.TabStop = true;
            RadioButtonOptimizacionNinguna.Text = "Ninguna";
            RadioButtonOptimizacionNinguna.UseVisualStyleBackColor = true;
            // 
            // ButtonIniciar
            // 
            ButtonIniciar.AutoSize = true;
            ButtonIniciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonIniciar.Dock = DockStyle.Fill;
            ButtonIniciar.Location = new Point(676, 3);
            ButtonIniciar.Name = "ButtonIniciar";
            ButtonIniciar.Size = new Size(320, 30);
            ButtonIniciar.TabIndex = 3;
            ButtonIniciar.Text = "Iniciar importación";
            ButtonIniciar.UseVisualStyleBackColor = true;
            ButtonIniciar.Click += ButtonIniciar_Click;
            // 
            // ProgressBarArchivo
            // 
            ProgressBarArchivo.Dock = DockStyle.Fill;
            ProgressBarArchivo.Location = new Point(3, 424);
            ProgressBarArchivo.Name = "ProgressBarArchivo";
            ProgressBarArchivo.Size = new Size(999, 44);
            ProgressBarArchivo.TabIndex = 4;
            ProgressBarArchivo.Visible = false;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Dock = DockStyle.Fill;
            LabelEstado.Location = new Point(3, 471);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(999, 30);
            LabelEstado.TabIndex = 5;
            LabelEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 501);
            Controls.Add(TableLayoutPanelMain);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CS-Padrón importador";
            WindowState = FormWindowState.Maximized;
            TableLayoutPanelMain.ResumeLayout(false);
            TableLayoutPanelMain.PerformLayout();
            TableLayoutPanelCarpeta.ResumeLayout(false);
            TableLayoutPanelCarpeta.PerformLayout();
            TableLayoutPanelSeleccionar.ResumeLayout(false);
            TableLayoutPanelSeleccionar.PerformLayout();
            TableLayoutPanelIniciar.ResumeLayout(false);
            TableLayoutPanelIniciar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelMain;
        private TableLayoutPanel TableLayoutPanelCarpeta;
        private Label LabelCarpeta;
        private TextBox TextBoxCarpeta;
        private Button ButtonExaminar;
        private Button ButtonBuscar;
        private CheckedListBox CheckedListBoxArchivos;
        private TableLayoutPanel TableLayoutPanelSeleccionar;
        private Button ButtonSeleccionarTodos;
        private Button ButtonSeleccionarNinguno;
        private Button ButtonIniciar;
        private ProgressBar ProgressBarArchivo;
        private Label LabelEstado;
        private TableLayoutPanel TableLayoutPanelIniciar;
        private RadioButton RadioButtonOptimizacionMaxima;
        private RadioButton RadioButtonOptimizacionIntermedia;
        private RadioButton RadioButtonOptimizacionNinguna;
        private Label LabelOptimizacion;
    }
}
