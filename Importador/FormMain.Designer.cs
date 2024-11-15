﻿namespace CS_Padron_Importador
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
            ButtonIniciar = new Button();
            ProgressBarArchivo = new ProgressBar();
            LabelEstado = new Label();
            TableLayoutPanelMain.SuspendLayout();
            TableLayoutPanelCarpeta.SuspendLayout();
            TableLayoutPanelSeleccionar.SuspendLayout();
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
            TableLayoutPanelMain.Controls.Add(ButtonIniciar, 0, 3);
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
            TableLayoutPanelMain.Size = new Size(766, 329);
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
            TableLayoutPanelCarpeta.Size = new Size(760, 36);
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
            TextBoxCarpeta.Size = new Size(524, 27);
            TextBoxCarpeta.TabIndex = 1;
            // 
            // ButtonExaminar
            // 
            ButtonExaminar.AutoSize = true;
            ButtonExaminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonExaminar.Location = new Point(603, 3);
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
            ButtonBuscar.Location = new Point(637, 3);
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
            CheckedListBoxArchivos.Size = new Size(760, 123);
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
            TableLayoutPanelSeleccionar.Location = new Point(3, 174);
            TableLayoutPanelSeleccionar.Name = "TableLayoutPanelSeleccionar";
            TableLayoutPanelSeleccionar.RowCount = 1;
            TableLayoutPanelSeleccionar.RowStyles.Add(new RowStyle());
            TableLayoutPanelSeleccionar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSeleccionar.Size = new Size(760, 36);
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
            ButtonSeleccionarNinguno.Location = new Point(604, 3);
            ButtonSeleccionarNinguno.Name = "ButtonSeleccionarNinguno";
            ButtonSeleccionarNinguno.Size = new Size(153, 30);
            ButtonSeleccionarNinguno.TabIndex = 1;
            ButtonSeleccionarNinguno.Text = "Seleccionar ninguno";
            ButtonSeleccionarNinguno.UseVisualStyleBackColor = true;
            ButtonSeleccionarNinguno.Click += ButtonSeleccionarNinguno_Click;
            // 
            // ButtonIniciar
            // 
            ButtonIniciar.AutoSize = true;
            ButtonIniciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonIniciar.Dock = DockStyle.Fill;
            ButtonIniciar.Location = new Point(3, 216);
            ButtonIniciar.Name = "ButtonIniciar";
            ButtonIniciar.Size = new Size(760, 30);
            ButtonIniciar.TabIndex = 3;
            ButtonIniciar.Text = "Iniciar importación";
            ButtonIniciar.UseVisualStyleBackColor = true;
            ButtonIniciar.Click += ButtonIniciar_Click;
            // 
            // ProgressBarArchivo
            // 
            ProgressBarArchivo.Dock = DockStyle.Fill;
            ProgressBarArchivo.Location = new Point(3, 252);
            ProgressBarArchivo.Name = "ProgressBarArchivo";
            ProgressBarArchivo.Size = new Size(760, 44);
            ProgressBarArchivo.TabIndex = 4;
            ProgressBarArchivo.Visible = false;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Dock = DockStyle.Fill;
            LabelEstado.Location = new Point(3, 299);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(760, 30);
            LabelEstado.TabIndex = 5;
            LabelEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 329);
            Controls.Add(TableLayoutPanelMain);
            Name = "FormMain";
            Text = "CS-Padrón importador";
            TableLayoutPanelMain.ResumeLayout(false);
            TableLayoutPanelMain.PerformLayout();
            TableLayoutPanelCarpeta.ResumeLayout(false);
            TableLayoutPanelCarpeta.PerformLayout();
            TableLayoutPanelSeleccionar.ResumeLayout(false);
            TableLayoutPanelSeleccionar.PerformLayout();
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
    }
}
