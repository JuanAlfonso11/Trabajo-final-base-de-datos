namespace Trabajo_final
{
    partial class MantenimientosSuplidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientosSuplidores));
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRNC = new System.Windows.Forms.Label();
            this.lblBlance = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.gbxListadoSuplidores = new System.Windows.Forms.GroupBox();
            this.rdbContacto = new System.Windows.Forms.RadioButton();
            this.rdbRNC = new System.Windows.Forms.RadioButton();
            this.rdbTelefono = new System.Windows.Forms.RadioButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.dgvSuplidores = new System.Windows.Forms.DataGridView();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnREgresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.txtContacto = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxListadoSuplidores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuplidores)).BeginInit();
            this.gbxOpciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(57, 36);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(22, 18);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(91, 32);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(81, 24);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(91, 71);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 24);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(9, 160);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(66, 18);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblCelular
            // 
            this.lblCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(21, 201);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(54, 18);
            this.lblCelular.TabIndex = 5;
            this.lblCelular.Text = "Celular";
            // 
            // lblContacto
            // 
            this.lblContacto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(9, 117);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(69, 18);
            this.lblContacto.TabIndex = 6;
            this.lblContacto.Text = "Contacto";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(280, 29);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 18);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(265, 117);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 18);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblRNC
            // 
            this.lblRNC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRNC.AutoSize = true;
            this.lblRNC.Location = new System.Drawing.Point(244, 160);
            this.lblRNC.Name = "lblRNC";
            this.lblRNC.Size = new System.Drawing.Size(91, 18);
            this.lblRNC.TabIndex = 9;
            this.lblRNC.Text = "Cédula/RNC";
            // 
            // lblBlance
            // 
            this.lblBlance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBlance.AutoSize = true;
            this.lblBlance.Location = new System.Drawing.Point(275, 197);
            this.lblBlance.Name = "lblBlance";
            this.lblBlance.Size = new System.Drawing.Size(61, 18);
            this.lblBlance.TabIndex = 10;
            this.lblBlance.Text = "Balance";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefono.Location = new System.Drawing.Point(91, 156);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Mask = "(999) 000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(129, 24);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefono_MaskInputRejected);
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCelular.Location = new System.Drawing.Point(91, 193);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.Mask = "(999) 000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(129, 24);
            this.txtCelular.TabIndex = 13;
            this.txtCelular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCelular_MaskInputRejected);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(361, 21);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 24);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.Location = new System.Drawing.Point(361, 113);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(213, 24);
            this.txtDireccion.TabIndex = 15;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtRNC
            // 
            this.txtRNC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRNC.Location = new System.Drawing.Point(361, 156);
            this.txtRNC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(177, 24);
            this.txtRNC.TabIndex = 16;
            this.txtRNC.TextChanged += new System.EventHandler(this.txtRNC_TextChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBalance.Location = new System.Drawing.Point(361, 193);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(140, 24);
            this.txtBalance.TabIndex = 17;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress);
            // 
            // gbxListadoSuplidores
            // 
            this.gbxListadoSuplidores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxListadoSuplidores.Controls.Add(this.rdbContacto);
            this.gbxListadoSuplidores.Controls.Add(this.rdbRNC);
            this.gbxListadoSuplidores.Controls.Add(this.rdbTelefono);
            this.gbxListadoSuplidores.Controls.Add(this.txtbusqueda);
            this.gbxListadoSuplidores.Controls.Add(this.rdbNombre);
            this.gbxListadoSuplidores.Controls.Add(this.lblBusqueda);
            this.gbxListadoSuplidores.Controls.Add(this.rdbID);
            this.gbxListadoSuplidores.Controls.Add(this.dgvSuplidores);
            this.gbxListadoSuplidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListadoSuplidores.Location = new System.Drawing.Point(47, 364);
            this.gbxListadoSuplidores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxListadoSuplidores.Name = "gbxListadoSuplidores";
            this.gbxListadoSuplidores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxListadoSuplidores.Size = new System.Drawing.Size(808, 289);
            this.gbxListadoSuplidores.TabIndex = 18;
            this.gbxListadoSuplidores.TabStop = false;
            this.gbxListadoSuplidores.Text = "Listado de Suplidores";
            this.gbxListadoSuplidores.Visible = false;
            this.gbxListadoSuplidores.Enter += new System.EventHandler(this.GbxListadoSuplidores_Enter);
            // 
            // rdbContacto
            // 
            this.rdbContacto.AutoSize = true;
            this.rdbContacto.Location = new System.Drawing.Point(519, 39);
            this.rdbContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbContacto.Name = "rdbContacto";
            this.rdbContacto.Size = new System.Drawing.Size(90, 22);
            this.rdbContacto.TabIndex = 7;
            this.rdbContacto.TabStop = true;
            this.rdbContacto.Text = "Contacto";
            this.rdbContacto.UseVisualStyleBackColor = true;
            this.rdbContacto.CheckedChanged += new System.EventHandler(this.rdcContacto_CheckedChanged);
            // 
            // rdbRNC
            // 
            this.rdbRNC.AutoSize = true;
            this.rdbRNC.Location = new System.Drawing.Point(445, 39);
            this.rdbRNC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbRNC.Name = "rdbRNC";
            this.rdbRNC.Size = new System.Drawing.Size(62, 22);
            this.rdbRNC.TabIndex = 6;
            this.rdbRNC.TabStop = true;
            this.rdbRNC.Text = "RNC";
            this.rdbRNC.UseVisualStyleBackColor = true;
            this.rdbRNC.CheckedChanged += new System.EventHandler(this.rdbRNC_CheckedChanged);
            // 
            // rdbTelefono
            // 
            this.rdbTelefono.AutoSize = true;
            this.rdbTelefono.Location = new System.Drawing.Point(343, 39);
            this.rdbTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbTelefono.Name = "rdbTelefono";
            this.rdbTelefono.Size = new System.Drawing.Size(87, 22);
            this.rdbTelefono.TabIndex = 5;
            this.rdbTelefono.TabStop = true;
            this.rdbTelefono.Text = "Teléfono";
            this.rdbTelefono.UseVisualStyleBackColor = true;
            this.rdbTelefono.CheckedChanged += new System.EventHandler(this.rdbTelefono_CheckedChanged);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(11, 68);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(604, 24);
            this.txtbusqueda.TabIndex = 4;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(244, 39);
            this.rdbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(83, 22);
            this.rdbNombre.TabIndex = 3;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(9, 39);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(158, 18);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "Criterios de Búsqueda:";
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(189, 39);
            this.rdbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(43, 22);
            this.rdbID.TabIndex = 1;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // dgvSuplidores
            // 
            this.dgvSuplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuplidores.Location = new System.Drawing.Point(11, 98);
            this.dgvSuplidores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSuplidores.Name = "dgvSuplidores";
            this.dgvSuplidores.RowHeadersWidth = 51;
            this.dgvSuplidores.RowTemplate.Height = 24;
            this.dgvSuplidores.Size = new System.Drawing.Size(787, 174);
            this.dgvSuplidores.TabIndex = 0;
            this.dgvSuplidores.Click += new System.EventHandler(this.dgvSuplidores_Click);
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxOpciones.Controls.Add(this.btnBuscar);
            this.gbxOpciones.Controls.Add(this.btnREgresar);
            this.gbxOpciones.Controls.Add(this.btnEliminar);
            this.gbxOpciones.Controls.Add(this.btnGuardar);
            this.gbxOpciones.Controls.Add(this.btnNuevo);
            this.gbxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpciones.Location = new System.Drawing.Point(677, 130);
            this.gbxOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxOpciones.Size = new System.Drawing.Size(244, 187);
            this.gbxOpciones.TabIndex = 19;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones";
            this.gbxOpciones.Enter += new System.EventHandler(this.GbxOpciones_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(124, 81);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 42);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnREgresar
            // 
            this.btnREgresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnREgresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnREgresar.Location = new System.Drawing.Point(5, 128);
            this.btnREgresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnREgresar.Name = "btnREgresar";
            this.btnREgresar.Size = new System.Drawing.Size(231, 42);
            this.btnREgresar.TabIndex = 3;
            this.btnREgresar.Text = "Regresar";
            this.btnREgresar.UseVisualStyleBackColor = false;
            this.btnREgresar.Click += new System.EventHandler(this.btnREgresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(7, 81);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(124, 34);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(7, 34);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cbxProvincia);
            this.groupBox1.Controls.Add(this.cbxMunicipio);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.txtRNC);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.lblBlance);
            this.groupBox1.Controls.Add(this.lblRNC);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblContacto);
            this.groupBox1.Controls.Add(this.lblCelular);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(608, 244);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Suplidor";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Location = new System.Drawing.Point(268, 66);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(164, 26);
            this.cbxProvincia.TabIndex = 20;
            this.cbxProvincia.SelectedIndexChanged += new System.EventHandler(this.cbxProvincia_SelectedIndexChanged);
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(438, 66);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(164, 26);
            this.cbxMunicipio.TabIndex = 19;
            this.cbxMunicipio.SelectedIndexChanged += new System.EventHandler(this.cbxMunicipio_SelectedIndexChanged);
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(88, 113);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtContacto.Mask = "(999) 000-0000";
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(132, 24);
            this.txtContacto.TabIndex = 18;
            this.txtContacto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtContacto_MaskInputRejected);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 91);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento Suplidores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(789, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MantenimientosSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(948, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxListadoSuplidores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MantenimientosSuplidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Suplidores";
            this.Load += new System.EventHandler(this.MantenimientosSuplidores_Load);
            this.gbxListadoSuplidores.ResumeLayout(false);
            this.gbxListadoSuplidores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuplidores)).EndInit();
            this.gbxOpciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRNC;
        private System.Windows.Forms.Label lblBlance;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.GroupBox gbxListadoSuplidores;
        private System.Windows.Forms.RadioButton rdbRNC;
        private System.Windows.Forms.RadioButton rdbTelefono;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.DataGridView dgvSuplidores;
        private System.Windows.Forms.RadioButton rdbContacto;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnREgresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtContacto;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.ComboBox cbxProvincia;
    }
}