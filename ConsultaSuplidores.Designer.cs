namespace Trabajo_final
{
    partial class ConsultaSuplidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSuplidores));
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
            this.rdbBalance = new System.Windows.Forms.RadioButton();
            this.rdbRnc = new System.Windows.Forms.RadioButton();
            this.gbxRango = new System.Windows.Forms.GroupBox();
            this.btnBuscarRango = new System.Windows.Forms.Button();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.rdbTelefono = new System.Windows.Forms.RadioButton();
            this.rdbCelular = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
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
            this.gbxForm.Location = new System.Drawing.Point(727, 92);
            this.gbxForm.Margin = new System.Windows.Forms.Padding(2);
            this.gbxForm.Name = "gbxForm";
            this.gbxForm.Padding = new System.Windows.Forms.Padding(2);
            this.gbxForm.Size = new System.Drawing.Size(177, 133);
            this.gbxForm.TabIndex = 19;
            this.gbxForm.TabStop = false;
            this.gbxForm.Text = "Seleccione Formato";
            this.gbxForm.Visible = false;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.Control;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(58, 76);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(69, 36);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.SystemColors.Control;
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWord.Location = new System.Drawing.Point(97, 31);
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
            this.btnExcel.Location = new System.Drawing.Point(20, 31);
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
            this.gbxOpciones.Location = new System.Drawing.Point(569, 92);
            this.gbxOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Size = new System.Drawing.Size(150, 133);
            this.gbxOpciones.TabIndex = 18;
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
            this.btnRegresar.Location = new System.Drawing.Point(16, 76);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(119, 40);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Location = new System.Drawing.Point(16, 31);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(119, 38);
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
            this.gbxDetalles.Location = new System.Drawing.Point(479, 229);
            this.gbxDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDetalles.Size = new System.Drawing.Size(466, 324);
            this.gbxDetalles.TabIndex = 17;
            this.gbxDetalles.TabStop = false;
            this.gbxDetalles.Text = "Detalles";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(7, 17);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(455, 302);
            this.dgvDetalles.TabIndex = 0;
            // 
            // gbxRegistros
            // 
            this.gbxRegistros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxRegistros.Controls.Add(this.dgvRegistros);
            this.gbxRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRegistros.Location = new System.Drawing.Point(12, 229);
            this.gbxRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRegistros.Name = "gbxRegistros";
            this.gbxRegistros.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRegistros.Size = new System.Drawing.Size(462, 324);
            this.gbxRegistros.TabIndex = 16;
            this.gbxRegistros.TabStop = false;
            this.gbxRegistros.Text = "Suplidores Registrados";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(4, 17);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.Size = new System.Drawing.Size(453, 302);
            this.dgvRegistros.TabIndex = 0;
            this.dgvRegistros.Click += new System.EventHandler(this.dgvRegistros_Click);
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxCriterios.Controls.Add(this.rdbBalance);
            this.gbxCriterios.Controls.Add(this.rdbRnc);
            this.gbxCriterios.Controls.Add(this.gbxRango);
            this.gbxCriterios.Controls.Add(this.txtCriterio);
            this.gbxCriterios.Controls.Add(this.rdbTelefono);
            this.gbxCriterios.Controls.Add(this.rdbCelular);
            this.gbxCriterios.Controls.Add(this.rdbNombre);
            this.gbxCriterios.Controls.Add(this.rdbID);
            this.gbxCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCriterios.Location = new System.Drawing.Point(12, 92);
            this.gbxCriterios.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCriterios.Size = new System.Drawing.Size(553, 133);
            this.gbxCriterios.TabIndex = 15;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de búsqueda";
            // 
            // rdbBalance
            // 
            this.rdbBalance.AutoSize = true;
            this.rdbBalance.Location = new System.Drawing.Point(428, 18);
            this.rdbBalance.Margin = new System.Windows.Forms.Padding(2);
            this.rdbBalance.Name = "rdbBalance";
            this.rdbBalance.Size = new System.Drawing.Size(70, 19);
            this.rdbBalance.TabIndex = 8;
            this.rdbBalance.TabStop = true;
            this.rdbBalance.Text = "Balance";
            this.rdbBalance.UseVisualStyleBackColor = true;
            this.rdbBalance.CheckedChanged += new System.EventHandler(this.rdbBalance_CheckedChanged);
            // 
            // rdbRnc
            // 
            this.rdbRnc.AutoSize = true;
            this.rdbRnc.Location = new System.Drawing.Point(373, 18);
            this.rdbRnc.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRnc.Name = "rdbRnc";
            this.rdbRnc.Size = new System.Drawing.Size(51, 19);
            this.rdbRnc.TabIndex = 6;
            this.rdbRnc.TabStop = true;
            this.rdbRnc.Text = "RNC";
            this.rdbRnc.UseVisualStyleBackColor = true;
            this.rdbRnc.CheckedChanged += new System.EventHandler(this.rdbRnc_CheckedChanged);
            // 
            // gbxRango
            // 
            this.gbxRango.Controls.Add(this.btnBuscarRango);
            this.gbxRango.Controls.Add(this.txtHasta);
            this.gbxRango.Controls.Add(this.lblHasta);
            this.gbxRango.Controls.Add(this.txtDesde);
            this.gbxRango.Controls.Add(this.lblDesde);
            this.gbxRango.Location = new System.Drawing.Point(17, 64);
            this.gbxRango.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRango.Name = "gbxRango";
            this.gbxRango.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRango.Size = new System.Drawing.Size(407, 52);
            this.gbxRango.TabIndex = 5;
            this.gbxRango.TabStop = false;
            this.gbxRango.Text = "Rango";
            // 
            // btnBuscarRango
            // 
            this.btnBuscarRango.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarRango.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarRango.Location = new System.Drawing.Point(326, 15);
            this.btnBuscarRango.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarRango.Name = "btnBuscarRango";
            this.btnBuscarRango.Size = new System.Drawing.Size(61, 28);
            this.btnBuscarRango.TabIndex = 4;
            this.btnBuscarRango.Text = "Buscar";
            this.btnBuscarRango.UseVisualStyleBackColor = false;
            this.btnBuscarRango.Click += new System.EventHandler(this.btnBuscarRango_Click);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(211, 18);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(2);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(92, 21);
            this.txtHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(168, 22);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 15);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(66, 18);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(90, 21);
            this.txtDesde.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(19, 22);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 15);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(17, 39);
            this.txtCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(458, 21);
            this.txtCriterio.TabIndex = 4;
            this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
            // 
            // rdbTelefono
            // 
            this.rdbTelefono.AutoSize = true;
            this.rdbTelefono.Location = new System.Drawing.Point(296, 18);
            this.rdbTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTelefono.Name = "rdbTelefono";
            this.rdbTelefono.Size = new System.Drawing.Size(73, 19);
            this.rdbTelefono.TabIndex = 3;
            this.rdbTelefono.TabStop = true;
            this.rdbTelefono.Text = "Teléfono";
            this.rdbTelefono.UseVisualStyleBackColor = true;
            this.rdbTelefono.CheckedChanged += new System.EventHandler(this.rdbTelefono_CheckedChanged);
            // 
            // rdbCelular
            // 
            this.rdbCelular.AutoSize = true;
            this.rdbCelular.Location = new System.Drawing.Point(228, 18);
            this.rdbCelular.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCelular.Name = "rdbCelular";
            this.rdbCelular.Size = new System.Drawing.Size(64, 19);
            this.rdbCelular.TabIndex = 2;
            this.rdbCelular.TabStop = true;
            this.rdbCelular.Text = "Celular";
            this.rdbCelular.UseVisualStyleBackColor = true;
            this.rdbCelular.CheckedChanged += new System.EventHandler(this.rdbCelular_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(105, 18);
            this.rdbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(119, 19);
            this.rdbNombre.TabIndex = 1;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre Suplidor";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(17, 18);
            this.rdbID.Margin = new System.Windows.Forms.Padding(2);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(84, 19);
            this.rdbID.TabIndex = 0;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "Id Suplidor";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 80);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Suplidores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(814, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(956, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxForm);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.gbxRegistros);
            this.Controls.Add(this.gbxCriterios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaSuplidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Suplidores";
            this.Load += new System.EventHandler(this.ConsultaSuplidores_Load);
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
        private System.Windows.Forms.RadioButton rdbRnc;
        private System.Windows.Forms.GroupBox gbxRango;
        private System.Windows.Forms.Button btnBuscarRango;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.RadioButton rdbTelefono;
        private System.Windows.Forms.RadioButton rdbCelular;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.RadioButton rdbBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}