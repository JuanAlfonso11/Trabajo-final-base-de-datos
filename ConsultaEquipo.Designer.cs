namespace Trabajo_final
{
    partial class ConsultaEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEquipo));
            this.gbxForm = new System.Windows.Forms.GroupBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.gbxFormato = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbxDetalles = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.gbxRegistros = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.rdbprecio = new System.Windows.Forms.RadioButton();
            this.rdbServicio = new System.Windows.Forms.RadioButton();
            this.gbxRango = new System.Windows.Forms.GroupBox();
            this.btnBuscarRango = new System.Windows.Forms.Button();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.rdbDisponibilidad = new System.Windows.Forms.RadioButton();
            this.rdbTipo = new System.Windows.Forms.RadioButton();
            this.rdbDescripcion = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxForm.SuspendLayout();
            this.gbxOpciones.SuspendLayout();
            this.gbxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.gbxRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.gbxRango.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxForm
            // 
            this.gbxForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxForm.Controls.Add(this.btnPdf);
            this.gbxForm.Controls.Add(this.btnWord);
            this.gbxForm.Controls.Add(this.btnExcel);
            this.gbxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxForm.Location = new System.Drawing.Point(745, 91);
            this.gbxForm.Margin = new System.Windows.Forms.Padding(2);
            this.gbxForm.Name = "gbxForm";
            this.gbxForm.Padding = new System.Windows.Forms.Padding(2);
            this.gbxForm.Size = new System.Drawing.Size(171, 152);
            this.gbxForm.TabIndex = 24;
            this.gbxForm.TabStop = false;
            this.gbxForm.Text = "Seleccione Formato";
            this.gbxForm.Visible = false;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.Control;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(54, 91);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(63, 36);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.SystemColors.Control;
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWord.Location = new System.Drawing.Point(93, 42);
            this.btnWord.Margin = new System.Windows.Forms.Padding(2);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(63, 36);
            this.btnWord.TabIndex = 1;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Location = new System.Drawing.Point(14, 42);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(63, 36);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxOpciones.Controls.Add(this.gbxFormato);
            this.gbxOpciones.Controls.Add(this.btnRegresar);
            this.gbxOpciones.Controls.Add(this.btnImprimir);
            this.gbxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpciones.Location = new System.Drawing.Point(577, 91);
            this.gbxOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Size = new System.Drawing.Size(150, 153);
            this.gbxOpciones.TabIndex = 23;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones";
            // 
            // gbxFormato
            // 
            this.gbxFormato.Location = new System.Drawing.Point(154, 42);
            this.gbxFormato.Margin = new System.Windows.Forms.Padding(2);
            this.gbxFormato.Name = "gbxFormato";
            this.gbxFormato.Padding = new System.Windows.Forms.Padding(2);
            this.gbxFormato.Size = new System.Drawing.Size(131, 81);
            this.gbxFormato.TabIndex = 4;
            this.gbxFormato.TabStop = false;
            this.gbxFormato.Text = "Seleccione Formato";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Location = new System.Drawing.Point(17, 89);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(115, 40);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Location = new System.Drawing.Point(17, 40);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(115, 38);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gbxDetalles
            // 
            this.gbxDetalles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxDetalles.Controls.Add(this.dgvDetalles);
            this.gbxDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalles.Location = new System.Drawing.Point(478, 248);
            this.gbxDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDetalles.Size = new System.Drawing.Size(470, 339);
            this.gbxDetalles.TabIndex = 22;
            this.gbxDetalles.TabStop = false;
            this.gbxDetalles.Text = "Detalles";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(7, 17);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(459, 314);
            this.dgvDetalles.TabIndex = 0;
            // 
            // gbxRegistros
            // 
            this.gbxRegistros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxRegistros.Controls.Add(this.dgvRegistros);
            this.gbxRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRegistros.Location = new System.Drawing.Point(11, 248);
            this.gbxRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRegistros.Name = "gbxRegistros";
            this.gbxRegistros.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRegistros.Size = new System.Drawing.Size(463, 339);
            this.gbxRegistros.TabIndex = 21;
            this.gbxRegistros.TabStop = false;
            this.gbxRegistros.Text = "Equipos Registrados";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(4, 17);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.Size = new System.Drawing.Size(455, 314);
            this.dgvRegistros.TabIndex = 0;
            this.dgvRegistros.Click += new System.EventHandler(this.dgvRegistros_Click);
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxCriterios.Controls.Add(this.rdbprecio);
            this.gbxCriterios.Controls.Add(this.rdbServicio);
            this.gbxCriterios.Controls.Add(this.gbxRango);
            this.gbxCriterios.Controls.Add(this.txtCriterio);
            this.gbxCriterios.Controls.Add(this.rdbDisponibilidad);
            this.gbxCriterios.Controls.Add(this.rdbTipo);
            this.gbxCriterios.Controls.Add(this.rdbDescripcion);
            this.gbxCriterios.Controls.Add(this.rdbID);
            this.gbxCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCriterios.Location = new System.Drawing.Point(11, 91);
            this.gbxCriterios.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCriterios.Size = new System.Drawing.Size(562, 153);
            this.gbxCriterios.TabIndex = 20;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de búsqueda";
            // 
            // rdbprecio
            // 
            this.rdbprecio.AutoSize = true;
            this.rdbprecio.Location = new System.Drawing.Point(437, 32);
            this.rdbprecio.Margin = new System.Windows.Forms.Padding(2);
            this.rdbprecio.Name = "rdbprecio";
            this.rdbprecio.Size = new System.Drawing.Size(60, 19);
            this.rdbprecio.TabIndex = 8;
            this.rdbprecio.TabStop = true;
            this.rdbprecio.Text = "Precio";
            this.rdbprecio.UseVisualStyleBackColor = true;
            this.rdbprecio.CheckedChanged += new System.EventHandler(this.rdbprecio_CheckedChanged);
            // 
            // rdbServicio
            // 
            this.rdbServicio.AutoSize = true;
            this.rdbServicio.Location = new System.Drawing.Point(365, 32);
            this.rdbServicio.Margin = new System.Windows.Forms.Padding(2);
            this.rdbServicio.Name = "rdbServicio";
            this.rdbServicio.Size = new System.Drawing.Size(68, 19);
            this.rdbServicio.TabIndex = 6;
            this.rdbServicio.TabStop = true;
            this.rdbServicio.Text = "Servicio";
            this.rdbServicio.UseVisualStyleBackColor = true;
            this.rdbServicio.CheckedChanged += new System.EventHandler(this.rdbServicio_CheckedChanged);
            // 
            // gbxRango
            // 
            this.gbxRango.Controls.Add(this.btnBuscarRango);
            this.gbxRango.Controls.Add(this.txtHasta);
            this.gbxRango.Controls.Add(this.lblHasta);
            this.gbxRango.Controls.Add(this.txtDesde);
            this.gbxRango.Controls.Add(this.lblDesde);
            this.gbxRango.Location = new System.Drawing.Point(29, 84);
            this.gbxRango.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRango.Name = "gbxRango";
            this.gbxRango.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRango.Size = new System.Drawing.Size(413, 56);
            this.gbxRango.TabIndex = 5;
            this.gbxRango.TabStop = false;
            this.gbxRango.Text = "Rango";
            // 
            // btnBuscarRango
            // 
            this.btnBuscarRango.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarRango.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarRango.Location = new System.Drawing.Point(336, 18);
            this.btnBuscarRango.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarRango.Name = "btnBuscarRango";
            this.btnBuscarRango.Size = new System.Drawing.Size(67, 27);
            this.btnBuscarRango.TabIndex = 4;
            this.btnBuscarRango.Text = "Buscar";
            this.btnBuscarRango.UseVisualStyleBackColor = false;
            this.btnBuscarRango.Click += new System.EventHandler(this.btnBuscarRango_Click);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(215, 21);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(2);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(88, 21);
            this.txtHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(172, 24);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 15);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(70, 21);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(90, 21);
            this.txtDesde.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(23, 24);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 15);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(29, 55);
            this.txtCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(444, 21);
            this.txtCriterio.TabIndex = 4;
            this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
            // 
            // rdbDisponibilidad
            // 
            this.rdbDisponibilidad.AutoSize = true;
            this.rdbDisponibilidad.Location = new System.Drawing.Point(257, 32);
            this.rdbDisponibilidad.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDisponibilidad.Name = "rdbDisponibilidad";
            this.rdbDisponibilidad.Size = new System.Drawing.Size(104, 19);
            this.rdbDisponibilidad.TabIndex = 3;
            this.rdbDisponibilidad.TabStop = true;
            this.rdbDisponibilidad.Text = "Disponibilidad";
            this.rdbDisponibilidad.UseVisualStyleBackColor = true;
            this.rdbDisponibilidad.CheckedChanged += new System.EventHandler(this.rdbDisponibilidad_CheckedChanged);
            // 
            // rdbTipo
            // 
            this.rdbTipo.AutoSize = true;
            this.rdbTipo.Location = new System.Drawing.Point(204, 32);
            this.rdbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTipo.Name = "rdbTipo";
            this.rdbTipo.Size = new System.Drawing.Size(49, 19);
            this.rdbTipo.TabIndex = 2;
            this.rdbTipo.TabStop = true;
            this.rdbTipo.Text = "Tipo";
            this.rdbTipo.UseVisualStyleBackColor = true;
            this.rdbTipo.CheckedChanged += new System.EventHandler(this.rdbTipo_CheckedChanged);
            // 
            // rdbDescripcion
            // 
            this.rdbDescripcion.AutoSize = true;
            this.rdbDescripcion.Location = new System.Drawing.Point(110, 32);
            this.rdbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDescripcion.Name = "rdbDescripcion";
            this.rdbDescripcion.Size = new System.Drawing.Size(90, 19);
            this.rdbDescripcion.TabIndex = 1;
            this.rdbDescripcion.TabStop = true;
            this.rdbDescripcion.Text = "Descripción";
            this.rdbDescripcion.UseVisualStyleBackColor = true;
            this.rdbDescripcion.CheckedChanged += new System.EventHandler(this.rdbDescripcion_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(29, 32);
            this.rdbID.Margin = new System.Windows.Forms.Padding(2);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(77, 19);
            this.rdbID.TabIndex = 0;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "Id Equipo";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 77);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Equipos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(817, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(959, 598);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxForm);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.gbxRegistros);
            this.Controls.Add(this.gbxCriterios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Equipos";
            this.Load += new System.EventHandler(this.ConsultaEquipo_Load);
            this.gbxForm.ResumeLayout(false);
            this.gbxOpciones.ResumeLayout(false);
            this.gbxDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.gbxRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.gbxRango.ResumeLayout(false);
            this.gbxRango.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxForm;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.GroupBox gbxFormato;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbxDetalles;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.GroupBox gbxRegistros;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.RadioButton rdbprecio;
        private System.Windows.Forms.RadioButton rdbServicio;
        private System.Windows.Forms.GroupBox gbxRango;
        private System.Windows.Forms.Button btnBuscarRango;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.RadioButton rdbDisponibilidad;
        private System.Windows.Forms.RadioButton rdbTipo;
        private System.Windows.Forms.RadioButton rdbDescripcion;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}