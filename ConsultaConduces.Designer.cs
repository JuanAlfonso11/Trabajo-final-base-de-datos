namespace Trabajo_final
{
    partial class ConsultaConduces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaConduces));
            this.gbxbusqueda = new System.Windows.Forms.GroupBox();
            this.gbxRango = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbIDCliente = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.gbxopciones = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbxformato = new System.Windows.Forms.GroupBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.gbxConduces = new System.Windows.Forms.GroupBox();
            this.dgvConduces = new System.Windows.Forms.DataGridView();
            this.gbxdetalles = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxbusqueda.SuspendLayout();
            this.gbxRango.SuspendLayout();
            this.gbxopciones.SuspendLayout();
            this.gbxformato.SuspendLayout();
            this.gbxConduces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduces)).BeginInit();
            this.gbxdetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxbusqueda
            // 
            this.gbxbusqueda.Controls.Add(this.gbxRango);
            this.gbxbusqueda.Controls.Add(this.txtBusqueda);
            this.gbxbusqueda.Controls.Add(this.rdbFecha);
            this.gbxbusqueda.Controls.Add(this.rdbIDCliente);
            this.gbxbusqueda.Controls.Add(this.rdbID);
            this.gbxbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxbusqueda.Location = new System.Drawing.Point(11, 85);
            this.gbxbusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxbusqueda.Name = "gbxbusqueda";
            this.gbxbusqueda.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxbusqueda.Size = new System.Drawing.Size(474, 154);
            this.gbxbusqueda.TabIndex = 0;
            this.gbxbusqueda.TabStop = false;
            this.gbxbusqueda.Text = "Criterios de Busqueda";
            // 
            // gbxRango
            // 
            this.gbxRango.Controls.Add(this.btnBuscar);
            this.gbxRango.Controls.Add(this.txtHasta);
            this.gbxRango.Controls.Add(this.lblHasta);
            this.gbxRango.Controls.Add(this.txtDesde);
            this.gbxRango.Controls.Add(this.lblDesde);
            this.gbxRango.Location = new System.Drawing.Point(14, 71);
            this.gbxRango.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxRango.Name = "gbxRango";
            this.gbxRango.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxRango.Size = new System.Drawing.Size(412, 74);
            this.gbxRango.TabIndex = 4;
            this.gbxRango.TabStop = false;
            this.gbxRango.Text = "Rango";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(308, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 31);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(195, 28);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(74, 21);
            this.txtHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(152, 31);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 15);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(62, 28);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(76, 21);
            this.txtDesde.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(14, 31);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 15);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 48);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(402, 21);
            this.txtBusqueda.TabIndex = 3;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(187, 25);
            this.rdbFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(59, 19);
            this.rdbFecha.TabIndex = 2;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            this.rdbFecha.CheckedChanged += new System.EventHandler(this.RdbFecha_CheckedChanged);
            // 
            // rdbIDCliente
            // 
            this.rdbIDCliente.AutoSize = true;
            this.rdbIDCliente.Location = new System.Drawing.Point(105, 25);
            this.rdbIDCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbIDCliente.Name = "rdbIDCliente";
            this.rdbIDCliente.Size = new System.Drawing.Size(78, 19);
            this.rdbIDCliente.TabIndex = 1;
            this.rdbIDCliente.TabStop = true;
            this.rdbIDCliente.Text = "ID Cliente";
            this.rdbIDCliente.UseVisualStyleBackColor = true;
            this.rdbIDCliente.CheckedChanged += new System.EventHandler(this.RdbIDCliente_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(12, 25);
            this.rdbID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(89, 19);
            this.rdbID.TabIndex = 0;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID Conduce";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.RdbID_CheckedChanged);
            // 
            // gbxopciones
            // 
            this.gbxopciones.Controls.Add(this.btnRegresar);
            this.gbxopciones.Controls.Add(this.btnImprimir);
            this.gbxopciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxopciones.Location = new System.Drawing.Point(498, 85);
            this.gbxopciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxopciones.Name = "gbxopciones";
            this.gbxopciones.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxopciones.Size = new System.Drawing.Size(154, 154);
            this.gbxopciones.TabIndex = 1;
            this.gbxopciones.TabStop = false;
            this.gbxopciones.Text = "Opciones";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Location = new System.Drawing.Point(18, 87);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 33);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Location = new System.Drawing.Point(18, 36);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 33);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // gbxformato
            // 
            this.gbxformato.Controls.Add(this.btnPDF);
            this.gbxformato.Controls.Add(this.btnExcel);
            this.gbxformato.Controls.Add(this.btnWord);
            this.gbxformato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxformato.Location = new System.Drawing.Point(675, 85);
            this.gbxformato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxformato.Name = "gbxformato";
            this.gbxformato.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxformato.Size = new System.Drawing.Size(190, 154);
            this.gbxformato.TabIndex = 2;
            this.gbxformato.TabStop = false;
            this.gbxformato.Text = "Seleccione Formato";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.Control;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(54, 92);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(77, 33);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Location = new System.Drawing.Point(97, 48);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(77, 33);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.SystemColors.Control;
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWord.Location = new System.Drawing.Point(16, 48);
            this.btnWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(77, 33);
            this.btnWord.TabIndex = 0;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.BtnWord_Click);
            // 
            // gbxConduces
            // 
            this.gbxConduces.Controls.Add(this.dgvConduces);
            this.gbxConduces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxConduces.Location = new System.Drawing.Point(11, 243);
            this.gbxConduces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxConduces.Name = "gbxConduces";
            this.gbxConduces.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxConduces.Size = new System.Drawing.Size(461, 311);
            this.gbxConduces.TabIndex = 3;
            this.gbxConduces.TabStop = false;
            this.gbxConduces.Text = "Conduces Registrados";
            // 
            // dgvConduces
            // 
            this.dgvConduces.AllowUserToAddRows = false;
            this.dgvConduces.AllowUserToDeleteRows = false;
            this.dgvConduces.AllowUserToResizeRows = false;
            this.dgvConduces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConduces.Location = new System.Drawing.Point(10, 21);
            this.dgvConduces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConduces.Name = "dgvConduces";
            this.dgvConduces.ReadOnly = true;
            this.dgvConduces.RowHeadersWidth = 51;
            this.dgvConduces.RowTemplate.Height = 24;
            this.dgvConduces.Size = new System.Drawing.Size(447, 286);
            this.dgvConduces.TabIndex = 0;
            this.dgvConduces.Click += new System.EventHandler(this.DgvConduces_Click);
            // 
            // gbxdetalles
            // 
            this.gbxdetalles.Controls.Add(this.dgvDetalles);
            this.gbxdetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxdetalles.Location = new System.Drawing.Point(476, 243);
            this.gbxdetalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxdetalles.Name = "gbxdetalles";
            this.gbxdetalles.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxdetalles.Size = new System.Drawing.Size(454, 311);
            this.gbxdetalles.TabIndex = 4;
            this.gbxdetalles.TabStop = false;
            this.gbxdetalles.Text = "Detalles";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(8, 21);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(442, 286);
            this.dgvDetalles.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 82);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(815, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Conduces";
            // 
            // ConsultaConduces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(941, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxdetalles);
            this.Controls.Add(this.gbxConduces);
            this.Controls.Add(this.gbxformato);
            this.Controls.Add(this.gbxopciones);
            this.Controls.Add(this.gbxbusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultaConduces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Conduces";
            this.Load += new System.EventHandler(this.ConsultaConduces_Load);
            this.gbxbusqueda.ResumeLayout(false);
            this.gbxbusqueda.PerformLayout();
            this.gbxRango.ResumeLayout(false);
            this.gbxRango.PerformLayout();
            this.gbxopciones.ResumeLayout(false);
            this.gbxformato.ResumeLayout(false);
            this.gbxConduces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduces)).EndInit();
            this.gbxdetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxbusqueda;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.RadioButton rdbIDCliente;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.GroupBox gbxopciones;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbxformato;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.GroupBox gbxConduces;
        private System.Windows.Forms.GroupBox gbxdetalles;
        private System.Windows.Forms.DataGridView dgvConduces;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.GroupBox gbxRango;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}