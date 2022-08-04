namespace Trabajo_final
{
    partial class ConsultaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEmpleado));
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
            this.gbxForm.Location = new System.Drawing.Point(722, 96);
            this.gbxForm.Margin = new System.Windows.Forms.Padding(2);
            this.gbxForm.Name = "gbxForm";
            this.gbxForm.Padding = new System.Windows.Forms.Padding(2);
            this.gbxForm.Size = new System.Drawing.Size(159, 152);
            this.gbxForm.TabIndex = 9;
            this.gbxForm.TabStop = false;
            this.gbxForm.Text = "Seleccione Formato";
            this.gbxForm.Visible = false;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.Control;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(50, 81);
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
            this.btnWord.Location = new System.Drawing.Point(81, 37);
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
            this.btnExcel.Location = new System.Drawing.Point(14, 37);
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
            this.gbxOpciones.Location = new System.Drawing.Point(568, 96);
            this.gbxOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Size = new System.Drawing.Size(150, 153);
            this.gbxOpciones.TabIndex = 8;
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
            this.btnRegresar.Location = new System.Drawing.Point(15, 88);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(118, 40);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Location = new System.Drawing.Point(15, 36);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 38);
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
            this.gbxDetalles.Location = new System.Drawing.Point(473, 253);
            this.gbxDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDetalles.Size = new System.Drawing.Size(458, 339);
            this.gbxDetalles.TabIndex = 7;
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
            this.dgvDetalles.Size = new System.Drawing.Size(447, 314);
            this.dgvDetalles.TabIndex = 0;
            // 
            // gbxRegistros
            // 
            this.gbxRegistros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxRegistros.Controls.Add(this.dgvRegistros);
            this.gbxRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRegistros.Location = new System.Drawing.Point(11, 253);
            this.gbxRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRegistros.Name = "gbxRegistros";
            this.gbxRegistros.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRegistros.Size = new System.Drawing.Size(458, 339);
            this.gbxRegistros.TabIndex = 6;
            this.gbxRegistros.TabStop = false;
            this.gbxRegistros.Text = "Empleados Registrados";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(4, 17);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.Size = new System.Drawing.Size(450, 314);
            this.dgvRegistros.TabIndex = 0;
            this.dgvRegistros.Click += new System.EventHandler(this.dgvRegistros_Click);
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxCriterios.Controls.Add(this.gbxRango);
            this.gbxCriterios.Controls.Add(this.txtCriterio);
            this.gbxCriterios.Controls.Add(this.rdbTelefono);
            this.gbxCriterios.Controls.Add(this.rdbCelular);
            this.gbxCriterios.Controls.Add(this.rdbNombre);
            this.gbxCriterios.Controls.Add(this.rdbID);
            this.gbxCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCriterios.Location = new System.Drawing.Point(11, 96);
            this.gbxCriterios.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCriterios.Size = new System.Drawing.Size(553, 153);
            this.gbxCriterios.TabIndex = 5;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de búsqueda";
            // 
            // gbxRango
            // 
            this.gbxRango.Controls.Add(this.btnBuscarRango);
            this.gbxRango.Controls.Add(this.txtHasta);
            this.gbxRango.Controls.Add(this.lblHasta);
            this.gbxRango.Controls.Add(this.txtDesde);
            this.gbxRango.Controls.Add(this.lblDesde);
            this.gbxRango.Location = new System.Drawing.Point(21, 78);
            this.gbxRango.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRango.Name = "gbxRango";
            this.gbxRango.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRango.Size = new System.Drawing.Size(433, 58);
            this.gbxRango.TabIndex = 5;
            this.gbxRango.TabStop = false;
            this.gbxRango.Text = "Rango";
            // 
            // btnBuscarRango
            // 
            this.btnBuscarRango.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarRango.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarRango.Location = new System.Drawing.Point(349, 18);
            this.btnBuscarRango.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarRango.Name = "btnBuscarRango";
            this.btnBuscarRango.Size = new System.Drawing.Size(61, 26);
            this.btnBuscarRango.TabIndex = 4;
            this.btnBuscarRango.Text = "Buscar";
            this.btnBuscarRango.UseVisualStyleBackColor = false;
            this.btnBuscarRango.Click += new System.EventHandler(this.btnBuscarRango_Click);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(218, 21);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(2);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(89, 21);
            this.txtHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(175, 24);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 15);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(63, 20);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(95, 21);
            this.txtDesde.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(16, 24);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 15);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(21, 53);
            this.txtCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(376, 21);
            this.txtCriterio.TabIndex = 4;
            this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
            // 
            // rdbTelefono
            // 
            this.rdbTelefono.AutoSize = true;
            this.rdbTelefono.Location = new System.Drawing.Point(324, 30);
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
            this.rdbCelular.Location = new System.Drawing.Point(256, 30);
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
            this.rdbNombre.Location = new System.Drawing.Point(122, 30);
            this.rdbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(130, 19);
            this.rdbNombre.TabIndex = 1;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre Empleado";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(21, 30);
            this.rdbID.Margin = new System.Windows.Forms.Padding(2);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(97, 19);
            this.rdbID.TabIndex = 0;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID Empleado";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 84);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Empleados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(818, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(942, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxForm);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.gbxRegistros);
            this.Controls.Add(this.gbxCriterios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Empleados";
            this.Load += new System.EventHandler(this.ConsultaEmpleado_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}