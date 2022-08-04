namespace Trabajo_final
{
    partial class ConsultaHistorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaHistorial));
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.gbxRango = new System.Windows.Forms.GroupBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbIDUsuario = new System.Windows.Forms.RadioButton();
            this.rdbIdHistorial = new System.Windows.Forms.RadioButton();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbxFormato = new System.Windows.Forms.GroupBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.gbxHistorial = new System.Windows.Forms.GroupBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.gbxDetalles = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxBusqueda.SuspendLayout();
            this.gbxRango.SuspendLayout();
            this.gbxOpciones.SuspendLayout();
            this.gbxFormato.SuspendLayout();
            this.gbxHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.gbxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.gbxRango);
            this.gbxBusqueda.Controls.Add(this.txtBusqueda);
            this.gbxBusqueda.Controls.Add(this.rdbFecha);
            this.gbxBusqueda.Controls.Add(this.rdbIDUsuario);
            this.gbxBusqueda.Controls.Add(this.rdbIdHistorial);
            this.gbxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBusqueda.Location = new System.Drawing.Point(11, 90);
            this.gbxBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBusqueda.Size = new System.Drawing.Size(440, 167);
            this.gbxBusqueda.TabIndex = 0;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Criterios de Búsqueda";
            // 
            // gbxRango
            // 
            this.gbxRango.Controls.Add(this.txtHasta);
            this.gbxRango.Controls.Add(this.btnBuscar);
            this.gbxRango.Controls.Add(this.lblHasta);
            this.gbxRango.Controls.Add(this.txtDesde);
            this.gbxRango.Controls.Add(this.lblDesde);
            this.gbxRango.Location = new System.Drawing.Point(16, 75);
            this.gbxRango.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRango.Name = "gbxRango";
            this.gbxRango.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRango.Size = new System.Drawing.Size(388, 85);
            this.gbxRango.TabIndex = 4;
            this.gbxRango.TabStop = false;
            this.gbxRango.Text = "Rango";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(181, 36);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(2);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(76, 21);
            this.txtHasta.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(296, 31);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 33);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(142, 38);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 15);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(52, 36);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(77, 21);
            this.txtDesde.TabIndex = 0;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(10, 38);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 15);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(16, 51);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(374, 21);
            this.txtBusqueda.TabIndex = 3;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(192, 30);
            this.rdbFecha.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(101, 19);
            this.rdbFecha.TabIndex = 2;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha Acceso";
            this.rdbFecha.UseVisualStyleBackColor = true;
            this.rdbFecha.CheckedChanged += new System.EventHandler(this.RdbFecha_CheckedChanged);
            // 
            // rdbIDUsuario
            // 
            this.rdbIDUsuario.AutoSize = true;
            this.rdbIDUsuario.Location = new System.Drawing.Point(105, 30);
            this.rdbIDUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.rdbIDUsuario.Name = "rdbIDUsuario";
            this.rdbIDUsuario.Size = new System.Drawing.Size(83, 19);
            this.rdbIDUsuario.TabIndex = 1;
            this.rdbIDUsuario.TabStop = true;
            this.rdbIDUsuario.Text = "ID Usuario";
            this.rdbIDUsuario.UseVisualStyleBackColor = true;
            this.rdbIDUsuario.CheckedChanged += new System.EventHandler(this.RdbIDUsuario_CheckedChanged);
            // 
            // rdbIdHistorial
            // 
            this.rdbIdHistorial.AutoSize = true;
            this.rdbIdHistorial.Location = new System.Drawing.Point(16, 30);
            this.rdbIdHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.rdbIdHistorial.Name = "rdbIdHistorial";
            this.rdbIdHistorial.Size = new System.Drawing.Size(85, 19);
            this.rdbIdHistorial.TabIndex = 0;
            this.rdbIdHistorial.TabStop = true;
            this.rdbIdHistorial.Text = "ID Historial";
            this.rdbIdHistorial.UseVisualStyleBackColor = true;
            this.rdbIdHistorial.CheckedChanged += new System.EventHandler(this.RdbIdHistorial_CheckedChanged);
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Controls.Add(this.btnRegresar);
            this.gbxOpciones.Controls.Add(this.btnImprimir);
            this.gbxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpciones.Location = new System.Drawing.Point(474, 90);
            this.gbxOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Size = new System.Drawing.Size(167, 167);
            this.gbxOpciones.TabIndex = 1;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Location = new System.Drawing.Point(14, 95);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(139, 41);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Location = new System.Drawing.Point(14, 48);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(139, 41);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // gbxFormato
            // 
            this.gbxFormato.Controls.Add(this.btnPDF);
            this.gbxFormato.Controls.Add(this.btnExcel);
            this.gbxFormato.Controls.Add(this.btnWord);
            this.gbxFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFormato.Location = new System.Drawing.Point(662, 90);
            this.gbxFormato.Margin = new System.Windows.Forms.Padding(2);
            this.gbxFormato.Name = "gbxFormato";
            this.gbxFormato.Padding = new System.Windows.Forms.Padding(2);
            this.gbxFormato.Size = new System.Drawing.Size(207, 167);
            this.gbxFormato.TabIndex = 2;
            this.gbxFormato.TabStop = false;
            this.gbxFormato.Text = "Seleccione el Formato";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.Control;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(67, 95);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(80, 33);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Location = new System.Drawing.Point(111, 48);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(79, 33);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.SystemColors.Control;
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWord.Location = new System.Drawing.Point(17, 48);
            this.btnWord.Margin = new System.Windows.Forms.Padding(2);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(79, 33);
            this.btnWord.TabIndex = 0;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.BtnWord_Click);
            // 
            // gbxHistorial
            // 
            this.gbxHistorial.Controls.Add(this.dgvHistorial);
            this.gbxHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHistorial.Location = new System.Drawing.Point(11, 272);
            this.gbxHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.gbxHistorial.Name = "gbxHistorial";
            this.gbxHistorial.Padding = new System.Windows.Forms.Padding(2);
            this.gbxHistorial.Size = new System.Drawing.Size(458, 286);
            this.gbxHistorial.TabIndex = 3;
            this.gbxHistorial.TabStop = false;
            this.gbxHistorial.Text = "Historial de Acceso";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(14, 20);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.Size = new System.Drawing.Size(440, 256);
            this.dgvHistorial.TabIndex = 0;
            this.dgvHistorial.Click += new System.EventHandler(this.DgvHistorial_Click);
            // 
            // gbxDetalles
            // 
            this.gbxDetalles.Controls.Add(this.dgvDetalles);
            this.gbxDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalles.Location = new System.Drawing.Point(474, 272);
            this.gbxDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDetalles.Size = new System.Drawing.Size(452, 286);
            this.gbxDetalles.TabIndex = 4;
            this.gbxDetalles.TabStop = false;
            this.gbxDetalles.Text = "Detalles";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(11, 21);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(437, 254);
            this.dgvDetalles.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 75);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Historial de Acceso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(798, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(937, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.gbxHistorial);
            this.Controls.Add(this.gbxFormato);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Historial de Acceso";
            this.Load += new System.EventHandler(this.ConsultaHistorial_Load);
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.gbxRango.ResumeLayout(false);
            this.gbxRango.PerformLayout();
            this.gbxOpciones.ResumeLayout(false);
            this.gbxFormato.ResumeLayout(false);
            this.gbxHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.gbxDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.RadioButton rdbIdHistorial;
        private System.Windows.Forms.GroupBox gbxRango;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.RadioButton rdbIDUsuario;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbxFormato;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.GroupBox gbxHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.GroupBox gbxDetalles;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}