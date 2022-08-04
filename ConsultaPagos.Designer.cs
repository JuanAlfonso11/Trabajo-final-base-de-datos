namespace Trabajo_final
{
    partial class ConsultaPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPagos));
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.gbxRango = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rdbConcepto = new System.Windows.Forms.RadioButton();
            this.rdbMonto = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbIdUsuario = new System.Windows.Forms.RadioButton();
            this.rdbSuplidor = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbxFormato = new System.Windows.Forms.GroupBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.gbxPagos = new System.Windows.Forms.GroupBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.gbxDetalles = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxBusqueda.SuspendLayout();
            this.gbxRango.SuspendLayout();
            this.gbxOpciones.SuspendLayout();
            this.gbxFormato.SuspendLayout();
            this.gbxPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
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
            this.gbxBusqueda.Controls.Add(this.rdbConcepto);
            this.gbxBusqueda.Controls.Add(this.rdbMonto);
            this.gbxBusqueda.Controls.Add(this.rdbFecha);
            this.gbxBusqueda.Controls.Add(this.rdbIdUsuario);
            this.gbxBusqueda.Controls.Add(this.rdbSuplidor);
            this.gbxBusqueda.Controls.Add(this.rdbID);
            this.gbxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBusqueda.Location = new System.Drawing.Point(11, 95);
            this.gbxBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBusqueda.Size = new System.Drawing.Size(476, 177);
            this.gbxBusqueda.TabIndex = 0;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Criterios de Busqueda";
            // 
            // gbxRango
            // 
            this.gbxRango.Controls.Add(this.lblHasta);
            this.gbxRango.Controls.Add(this.lblDesde);
            this.gbxRango.Controls.Add(this.btnBuscar);
            this.gbxRango.Controls.Add(this.txtHasta);
            this.gbxRango.Controls.Add(this.txtDesde);
            this.gbxRango.Location = new System.Drawing.Point(19, 99);
            this.gbxRango.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRango.Name = "gbxRango";
            this.gbxRango.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRango.Size = new System.Drawing.Size(425, 69);
            this.gbxRango.TabIndex = 7;
            this.gbxRango.TabStop = false;
            this.gbxRango.Text = "Rango";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(165, 33);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 15);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(15, 33);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 15);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Desde";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(324, 26);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(208, 30);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(2);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(99, 21);
            this.txtHasta.TabIndex = 1;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(62, 30);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(94, 21);
            this.txtDesde.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(19, 65);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(363, 21);
            this.txtBusqueda.TabIndex = 6;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // rdbConcepto
            // 
            this.rdbConcepto.AutoSize = true;
            this.rdbConcepto.Location = new System.Drawing.Point(237, 32);
            this.rdbConcepto.Margin = new System.Windows.Forms.Padding(2);
            this.rdbConcepto.Name = "rdbConcepto";
            this.rdbConcepto.Size = new System.Drawing.Size(77, 19);
            this.rdbConcepto.TabIndex = 5;
            this.rdbConcepto.TabStop = true;
            this.rdbConcepto.Text = "Concepto";
            this.rdbConcepto.UseVisualStyleBackColor = true;
            this.rdbConcepto.CheckedChanged += new System.EventHandler(this.RdbConcepto_CheckedChanged);
            // 
            // rdbMonto
            // 
            this.rdbMonto.AutoSize = true;
            this.rdbMonto.Location = new System.Drawing.Point(381, 32);
            this.rdbMonto.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMonto.Name = "rdbMonto";
            this.rdbMonto.Size = new System.Drawing.Size(60, 19);
            this.rdbMonto.TabIndex = 4;
            this.rdbMonto.TabStop = true;
            this.rdbMonto.Text = "Monto";
            this.rdbMonto.UseVisualStyleBackColor = true;
            this.rdbMonto.CheckedChanged += new System.EventHandler(this.RdbMonto_CheckedChanged);
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(318, 32);
            this.rdbFecha.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(59, 19);
            this.rdbFecha.TabIndex = 3;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            this.rdbFecha.CheckedChanged += new System.EventHandler(this.RdbFecha_CheckedChanged);
            // 
            // rdbIdUsuario
            // 
            this.rdbIdUsuario.AutoSize = true;
            this.rdbIdUsuario.Location = new System.Drawing.Point(150, 32);
            this.rdbIdUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.rdbIdUsuario.Name = "rdbIdUsuario";
            this.rdbIdUsuario.Size = new System.Drawing.Size(83, 19);
            this.rdbIdUsuario.TabIndex = 2;
            this.rdbIdUsuario.TabStop = true;
            this.rdbIdUsuario.Text = "ID Usuario";
            this.rdbIdUsuario.UseVisualStyleBackColor = true;
            this.rdbIdUsuario.CheckedChanged += new System.EventHandler(this.RdbIdUsuario_CheckedChanged);
            // 
            // rdbSuplidor
            // 
            this.rdbSuplidor.AutoSize = true;
            this.rdbSuplidor.Location = new System.Drawing.Point(60, 32);
            this.rdbSuplidor.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSuplidor.Name = "rdbSuplidor";
            this.rdbSuplidor.Size = new System.Drawing.Size(86, 19);
            this.rdbSuplidor.TabIndex = 1;
            this.rdbSuplidor.TabStop = true;
            this.rdbSuplidor.Text = "ID Suplidor";
            this.rdbSuplidor.UseVisualStyleBackColor = true;
            this.rdbSuplidor.CheckedChanged += new System.EventHandler(this.RdbSuplidor_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(19, 32);
            this.rdbID.Margin = new System.Windows.Forms.Padding(2);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(37, 19);
            this.rdbID.TabIndex = 0;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.RdbID_CheckedChanged);
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Controls.Add(this.btnImprimir);
            this.gbxOpciones.Controls.Add(this.btnRegresar);
            this.gbxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpciones.Location = new System.Drawing.Point(500, 95);
            this.gbxOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Size = new System.Drawing.Size(148, 177);
            this.gbxOpciones.TabIndex = 1;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Location = new System.Drawing.Point(15, 49);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 37);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Location = new System.Drawing.Point(15, 99);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(118, 37);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // gbxFormato
            // 
            this.gbxFormato.Controls.Add(this.btnPDF);
            this.gbxFormato.Controls.Add(this.btnExcel);
            this.gbxFormato.Controls.Add(this.btnWord);
            this.gbxFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFormato.Location = new System.Drawing.Point(664, 95);
            this.gbxFormato.Margin = new System.Windows.Forms.Padding(2);
            this.gbxFormato.Name = "gbxFormato";
            this.gbxFormato.Padding = new System.Windows.Forms.Padding(2);
            this.gbxFormato.Size = new System.Drawing.Size(224, 177);
            this.gbxFormato.TabIndex = 2;
            this.gbxFormato.TabStop = false;
            this.gbxFormato.Text = "Formato";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.Control;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(74, 99);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(82, 37);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Location = new System.Drawing.Point(119, 47);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(82, 39);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.SystemColors.Control;
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWord.Location = new System.Drawing.Point(19, 49);
            this.btnWord.Margin = new System.Windows.Forms.Padding(2);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(82, 37);
            this.btnWord.TabIndex = 0;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.BtnWord_Click);
            // 
            // gbxPagos
            // 
            this.gbxPagos.Controls.Add(this.dgvPagos);
            this.gbxPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPagos.Location = new System.Drawing.Point(11, 276);
            this.gbxPagos.Margin = new System.Windows.Forms.Padding(2);
            this.gbxPagos.Name = "gbxPagos";
            this.gbxPagos.Padding = new System.Windows.Forms.Padding(2);
            this.gbxPagos.Size = new System.Drawing.Size(454, 296);
            this.gbxPagos.TabIndex = 3;
            this.gbxPagos.TabStop = false;
            this.gbxPagos.Text = "Pagos";
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AllowUserToResizeRows = false;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(10, 18);
            this.dgvPagos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersWidth = 51;
            this.dgvPagos.RowTemplate.Height = 24;
            this.dgvPagos.Size = new System.Drawing.Size(434, 266);
            this.dgvPagos.TabIndex = 0;
            this.dgvPagos.Click += new System.EventHandler(this.DgvPagos_Click);
            // 
            // gbxDetalles
            // 
            this.gbxDetalles.Controls.Add(this.dgvDetalles);
            this.gbxDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalles.Location = new System.Drawing.Point(472, 276);
            this.gbxDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDetalles.Size = new System.Drawing.Size(462, 296);
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
            this.dgvDetalles.Location = new System.Drawing.Point(10, 18);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(448, 266);
            this.dgvDetalles.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 76);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Pagos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(815, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(945, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.gbxPagos);
            this.Controls.Add(this.gbxFormato);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Pagos";
            this.Load += new System.EventHandler(this.ConsultaPagos_Load);
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.gbxRango.ResumeLayout(false);
            this.gbxRango.PerformLayout();
            this.gbxOpciones.ResumeLayout(false);
            this.gbxFormato.ResumeLayout(false);
            this.gbxPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.gbxDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.GroupBox gbxFormato;
        private System.Windows.Forms.GroupBox gbxPagos;
        private System.Windows.Forms.GroupBox gbxDetalles;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rdbConcepto;
        private System.Windows.Forms.RadioButton rdbMonto;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.RadioButton rdbIdUsuario;
        private System.Windows.Forms.RadioButton rdbSuplidor;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.GroupBox gbxRango;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}