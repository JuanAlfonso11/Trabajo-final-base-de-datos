namespace Trabajo_final
{
    partial class MantenimientoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoUsuarios));
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.chkSiNo = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxListadoUsuarios = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rdbHabilitado = new System.Windows.Forms.RadioButton();
            this.rdbTipo = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.lblCriterios = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxOpciones.SuspendLayout();
            this.gbxListadoUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(71, 38);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ID.Size = new System.Drawing.Size(22, 18);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(3, 127);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(85, 18);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Contraseña";
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.AutoSize = true;
            this.lblHabilitado.Location = new System.Drawing.Point(12, 215);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(73, 18);
            this.lblHabilitado.TabIndex = 3;
            this.lblHabilitado.Text = "Habilitado";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(55, 172);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(37, 18);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Administrador",
            "Invitado"});
            this.cbxTipo.Location = new System.Drawing.Point(101, 169);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(179, 26);
            this.cbxTipo.TabIndex = 8;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.CbxTipo_SelectedIndexChanged);
            // 
            // chkSiNo
            // 
            this.chkSiNo.AutoSize = true;
            this.chkSiNo.Location = new System.Drawing.Point(101, 215);
            this.chkSiNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSiNo.Name = "chkSiNo";
            this.chkSiNo.Size = new System.Drawing.Size(67, 22);
            this.chkSiNo.TabIndex = 9;
            this.chkSiNo.Text = "Si/No";
            this.chkSiNo.UseVisualStyleBackColor = true;
            this.chkSiNo.CheckedChanged += new System.EventHandler(this.ChkSiNo_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(101, 34);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(71, 24);
            this.txtID.TabIndex = 10;
            this.txtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 24);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(101, 123);
            this.txtContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(217, 24);
            this.txtContra.TabIndex = 12;
            this.txtContra.UseSystemPasswordChar = true;
            this.txtContra.TextChanged += new System.EventHandler(this.TxtContra_TextChanged);
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOpciones.Controls.Add(this.btnBuscar);
            this.gbxOpciones.Controls.Add(this.btnRegresar);
            this.gbxOpciones.Controls.Add(this.btnEliminar);
            this.gbxOpciones.Controls.Add(this.btnGuardar);
            this.gbxOpciones.Controls.Add(this.btnNuevo);
            this.gbxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpciones.Location = new System.Drawing.Point(488, 155);
            this.gbxOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxOpciones.Size = new System.Drawing.Size(295, 188);
            this.gbxOpciones.TabIndex = 13;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones";
            this.gbxOpciones.Enter += new System.EventHandler(this.GbxOpciones_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(151, 76);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 46);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Location = new System.Drawing.Point(19, 127);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(259, 42);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(17, 76);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 46);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(151, 26);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 46);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(17, 26);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(128, 46);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click_1);
            // 
            // gbxListadoUsuarios
            // 
            this.gbxListadoUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxListadoUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxListadoUsuarios.Controls.Add(this.txtBusqueda);
            this.gbxListadoUsuarios.Controls.Add(this.rdbHabilitado);
            this.gbxListadoUsuarios.Controls.Add(this.rdbTipo);
            this.gbxListadoUsuarios.Controls.Add(this.rdbNombre);
            this.gbxListadoUsuarios.Controls.Add(this.rdbID);
            this.gbxListadoUsuarios.Controls.Add(this.lblCriterios);
            this.gbxListadoUsuarios.Controls.Add(this.dgvUsuarios);
            this.gbxListadoUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListadoUsuarios.Location = new System.Drawing.Point(37, 377);
            this.gbxListadoUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxListadoUsuarios.Name = "gbxListadoUsuarios";
            this.gbxListadoUsuarios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxListadoUsuarios.Size = new System.Drawing.Size(795, 283);
            this.gbxListadoUsuarios.TabIndex = 14;
            this.gbxListadoUsuarios.TabStop = false;
            this.gbxListadoUsuarios.Text = "Listado de Usuarios";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(23, 66);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(508, 24);
            this.txtBusqueda.TabIndex = 6;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // rdbHabilitado
            // 
            this.rdbHabilitado.AutoSize = true;
            this.rdbHabilitado.Location = new System.Drawing.Point(424, 31);
            this.rdbHabilitado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbHabilitado.Name = "rdbHabilitado";
            this.rdbHabilitado.Size = new System.Drawing.Size(94, 22);
            this.rdbHabilitado.TabIndex = 5;
            this.rdbHabilitado.TabStop = true;
            this.rdbHabilitado.Text = "Habilitado";
            this.rdbHabilitado.UseVisualStyleBackColor = true;
            this.rdbHabilitado.CheckedChanged += new System.EventHandler(this.RdbHabilitado_CheckedChanged);
            // 
            // rdbTipo
            // 
            this.rdbTipo.AutoSize = true;
            this.rdbTipo.Location = new System.Drawing.Point(353, 31);
            this.rdbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbTipo.Name = "rdbTipo";
            this.rdbTipo.Size = new System.Drawing.Size(58, 22);
            this.rdbTipo.TabIndex = 4;
            this.rdbTipo.TabStop = true;
            this.rdbTipo.Text = "Tipo";
            this.rdbTipo.UseVisualStyleBackColor = true;
            this.rdbTipo.CheckedChanged += new System.EventHandler(this.RdbTipo_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(255, 31);
            this.rdbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(83, 22);
            this.rdbNombre.TabIndex = 3;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.RdbNombre_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(200, 31);
            this.rdbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(43, 22);
            this.rdbID.TabIndex = 2;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.RdbID_CheckedChanged);
            // 
            // lblCriterios
            // 
            this.lblCriterios.AutoSize = true;
            this.lblCriterios.Location = new System.Drawing.Point(20, 31);
            this.lblCriterios.Name = "lblCriterios";
            this.lblCriterios.Size = new System.Drawing.Size(158, 18);
            this.lblCriterios.TabIndex = 1;
            this.lblCriterios.Text = "Criterios de Búsqueda:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(23, 102);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(755, 175);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellContentClick);
            this.dgvUsuarios.Click += new System.EventHandler(this.DgvUsuarios_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtContra);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.txtID);
            this.gbxDatos.Controls.Add(this.chkSiNo);
            this.gbxDatos.Controls.Add(this.cbxTipo);
            this.gbxDatos.Controls.Add(this.lblTipo);
            this.gbxDatos.Controls.Add(this.lblHabilitado);
            this.gbxDatos.Controls.Add(this.lblContra);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.lbl_ID);
            this.gbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(61, 121);
            this.gbxDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxDatos.Size = new System.Drawing.Size(408, 250);
            this.gbxDatos.TabIndex = 15;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos del Usuario";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 101);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(680, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(845, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxListadoUsuarios);
            this.Controls.Add(this.gbxOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MantenimientoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Usuarios";
            this.Load += new System.EventHandler(this.MantenimientoUsuarios_Load);
            this.gbxOpciones.ResumeLayout(false);
            this.gbxListadoUsuarios.ResumeLayout(false);
            this.gbxListadoUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblHabilitado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.CheckBox chkSiNo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxListadoUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rdbHabilitado;
        private System.Windows.Forms.RadioButton rdbTipo;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.Label lblCriterios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}