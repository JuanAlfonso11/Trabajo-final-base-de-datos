namespace Trabajo_final
{
    partial class Proceso_de_conduces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proceso_de_conduces));
            this.lblusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.btnPocesarConduce = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevaCond = new System.Windows.Forms.Button();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descipcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxAgregar = new System.Windows.Forms.GroupBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtCanitdad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarEquipo = new System.Windows.Forms.Button();
            this.txtDecrip = new System.Windows.Forms.TextBox();
            this.txtIdEqui = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gbxEquipo = new System.Windows.Forms.GroupBox();
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.txtBusquedaEquipo = new System.Windows.Forms.TextBox();
            this.rdbtipo = new System.Windows.Forms.RadioButton();
            this.rdbDescripcion = new System.Windows.Forms.RadioButton();
            this.rdbEquipo = new System.Windows.Forms.RadioButton();
            this.gbxBuscarCliente = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtBusquedaClientes = new System.Windows.Forms.TextBox();
            this.rdbDireccion = new System.Windows.Forms.RadioButton();
            this.rdbTelefono = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbIdCliente = new System.Windows.Forms.RadioButton();
            this.gbxDC = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.RichTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.gbxOpciones.SuspendLayout();
            this.gbxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.gbxAgregar.SuspendLayout();
            this.gbxEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.gbxBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbxDC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(824, 8);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(2);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.ReadOnly = true;
            this.lblusuario.Size = new System.Drawing.Size(76, 21);
            this.lblusuario.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(770, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario";
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Controls.Add(this.btnPocesarConduce);
            this.gbxOpciones.Controls.Add(this.btnRetornar);
            this.gbxOpciones.Controls.Add(this.btnCancelar);
            this.gbxOpciones.Controls.Add(this.btnNuevaCond);
            this.gbxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpciones.Location = new System.Drawing.Point(738, 33);
            this.gbxOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Size = new System.Drawing.Size(183, 368);
            this.gbxOpciones.TabIndex = 16;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones";
            // 
            // btnPocesarConduce
            // 
            this.btnPocesarConduce.BackColor = System.Drawing.SystemColors.Control;
            this.btnPocesarConduce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPocesarConduce.Location = new System.Drawing.Point(38, 193);
            this.btnPocesarConduce.Margin = new System.Windows.Forms.Padding(2);
            this.btnPocesarConduce.Name = "btnPocesarConduce";
            this.btnPocesarConduce.Size = new System.Drawing.Size(108, 65);
            this.btnPocesarConduce.TabIndex = 3;
            this.btnPocesarConduce.Text = "Procesar Conduce";
            this.btnPocesarConduce.UseVisualStyleBackColor = false;
            this.btnPocesarConduce.Click += new System.EventHandler(this.btnPocesarConduce_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetornar.Location = new System.Drawing.Point(38, 275);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(108, 65);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.Text = "Regresar";
            this.btnRetornar.UseVisualStyleBackColor = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(38, 109);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 65);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevaCond
            // 
            this.btnNuevaCond.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevaCond.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevaCond.Location = new System.Drawing.Point(38, 30);
            this.btnNuevaCond.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaCond.Name = "btnNuevaCond";
            this.btnNuevaCond.Size = new System.Drawing.Size(108, 65);
            this.btnNuevaCond.TabIndex = 0;
            this.btnNuevaCond.Text = "Nuevo Conduce";
            this.btnNuevaCond.UseVisualStyleBackColor = false;
            this.btnNuevaCond.Click += new System.EventHandler(this.btnNuevaCond_Click);
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Controls.Add(this.dgvDetalleFactura);
            this.gbxDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalle.Location = new System.Drawing.Point(11, 458);
            this.gbxDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDetalle.Size = new System.Drawing.Size(686, 143);
            this.gbxDetalle.TabIndex = 15;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.AllowUserToDeleteRows = false;
            this.dgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descipcion,
            this.Cantidad,
            this.Empleado});
            this.dgvDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(2, 16);
            this.dgvDetalleFactura.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            this.dgvDetalleFactura.RowHeadersWidth = 51;
            this.dgvDetalleFactura.RowTemplate.Height = 24;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(682, 125);
            this.dgvDetalleFactura.TabIndex = 0;
            this.dgvDetalleFactura.DoubleClick += new System.EventHandler(this.dgvDetalleFactura_DoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Descipcion
            // 
            this.Descipcion.HeaderText = "Descripcion";
            this.Descipcion.MinimumWidth = 6;
            this.Descipcion.Name = "Descipcion";
            this.Descipcion.ReadOnly = true;
            this.Descipcion.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.MinimumWidth = 6;
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            this.Empleado.Width = 125;
            // 
            // gbxAgregar
            // 
            this.gbxAgregar.BackColor = System.Drawing.Color.Transparent;
            this.gbxAgregar.Controls.Add(this.lblEmpleado);
            this.gbxAgregar.Controls.Add(this.cbxEmpleado);
            this.gbxAgregar.Controls.Add(this.lblcantidad);
            this.gbxAgregar.Controls.Add(this.txtCanitdad);
            this.gbxAgregar.Controls.Add(this.btnAgregar);
            this.gbxAgregar.Controls.Add(this.btnBuscarEquipo);
            this.gbxAgregar.Controls.Add(this.txtDecrip);
            this.gbxAgregar.Controls.Add(this.txtIdEqui);
            this.gbxAgregar.Controls.Add(this.lblDescripcion);
            this.gbxAgregar.Controls.Add(this.lblID);
            this.gbxAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAgregar.Location = new System.Drawing.Point(11, 373);
            this.gbxAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAgregar.Name = "gbxAgregar";
            this.gbxAgregar.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAgregar.Size = new System.Drawing.Size(686, 81);
            this.gbxAgregar.TabIndex = 14;
            this.gbxAgregar.TabStop = false;
            this.gbxAgregar.Text = "Agregar Equipo";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(423, 21);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(64, 15);
            this.lblEmpleado.TabIndex = 14;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(426, 38);
            this.cbxEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(167, 23);
            this.cbxEmpleado.TabIndex = 13;
            this.cbxEmpleado.SelectionChangeCommitted += new System.EventHandler(this.cbxEmpleado_SelectionChangeCommitted);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(347, 22);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(71, 15);
            this.lblcantidad.TabIndex = 12;
            this.lblcantidad.Text = "Cant. Horas";
            // 
            // txtCanitdad
            // 
            this.txtCanitdad.Location = new System.Drawing.Point(350, 39);
            this.txtCanitdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCanitdad.Name = "txtCanitdad";
            this.txtCanitdad.Size = new System.Drawing.Size(72, 21);
            this.txtCanitdad.TabIndex = 11;
            this.txtCanitdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanitdad_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(608, 34);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 30);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarEquipo
            // 
            this.btnBuscarEquipo.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarEquipo.Location = new System.Drawing.Point(13, 36);
            this.btnBuscarEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEquipo.Name = "btnBuscarEquipo";
            this.btnBuscarEquipo.Size = new System.Drawing.Size(56, 27);
            this.btnBuscarEquipo.TabIndex = 9;
            this.btnBuscarEquipo.Text = "Buscar";
            this.btnBuscarEquipo.UseVisualStyleBackColor = false;
            this.btnBuscarEquipo.Click += new System.EventHandler(this.btnBuscarEquipo_Click);
            // 
            // txtDecrip
            // 
            this.txtDecrip.Location = new System.Drawing.Point(118, 39);
            this.txtDecrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtDecrip.Name = "txtDecrip";
            this.txtDecrip.Size = new System.Drawing.Size(228, 21);
            this.txtDecrip.TabIndex = 6;
            // 
            // txtIdEqui
            // 
            this.txtIdEqui.Location = new System.Drawing.Point(79, 39);
            this.txtIdEqui.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEqui.Name = "txtIdEqui";
            this.txtIdEqui.Size = new System.Drawing.Size(36, 21);
            this.txtIdEqui.TabIndex = 5;
            this.txtIdEqui.TextChanged += new System.EventHandler(this.txtIdEqui_TextChanged);
            this.txtIdEqui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEqui_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(115, 22);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(76, 22);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // gbxEquipo
            // 
            this.gbxEquipo.BackColor = System.Drawing.Color.Transparent;
            this.gbxEquipo.Controls.Add(this.dgvEquipo);
            this.gbxEquipo.Controls.Add(this.txtBusquedaEquipo);
            this.gbxEquipo.Controls.Add(this.rdbtipo);
            this.gbxEquipo.Controls.Add(this.rdbDescripcion);
            this.gbxEquipo.Controls.Add(this.rdbEquipo);
            this.gbxEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEquipo.Location = new System.Drawing.Point(376, 180);
            this.gbxEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxEquipo.Name = "gbxEquipo";
            this.gbxEquipo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxEquipo.Size = new System.Drawing.Size(358, 189);
            this.gbxEquipo.TabIndex = 13;
            this.gbxEquipo.TabStop = false;
            this.gbxEquipo.Text = "Buscar Equipo";
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Location = new System.Drawing.Point(14, 70);
            this.dgvEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.RowHeadersWidth = 51;
            this.dgvEquipo.RowTemplate.Height = 24;
            this.dgvEquipo.Size = new System.Drawing.Size(331, 103);
            this.dgvEquipo.TabIndex = 4;
            this.dgvEquipo.Click += new System.EventHandler(this.dgvEquipo_Click);
            // 
            // txtBusquedaEquipo
            // 
            this.txtBusquedaEquipo.Location = new System.Drawing.Point(16, 47);
            this.txtBusquedaEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusquedaEquipo.Name = "txtBusquedaEquipo";
            this.txtBusquedaEquipo.Size = new System.Drawing.Size(250, 21);
            this.txtBusquedaEquipo.TabIndex = 3;
            this.txtBusquedaEquipo.TextChanged += new System.EventHandler(this.txtBusquedaEquipo_TextChanged);
            // 
            // rdbtipo
            // 
            this.rdbtipo.AutoSize = true;
            this.rdbtipo.Location = new System.Drawing.Point(191, 25);
            this.rdbtipo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtipo.Name = "rdbtipo";
            this.rdbtipo.Size = new System.Drawing.Size(49, 19);
            this.rdbtipo.TabIndex = 2;
            this.rdbtipo.TabStop = true;
            this.rdbtipo.Text = "Tipo";
            this.rdbtipo.UseVisualStyleBackColor = true;
            this.rdbtipo.CheckedChanged += new System.EventHandler(this.rdbtipo_CheckedChanged);
            // 
            // rdbDescripcion
            // 
            this.rdbDescripcion.AutoSize = true;
            this.rdbDescripcion.Location = new System.Drawing.Point(97, 25);
            this.rdbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDescripcion.Name = "rdbDescripcion";
            this.rdbDescripcion.Size = new System.Drawing.Size(90, 19);
            this.rdbDescripcion.TabIndex = 1;
            this.rdbDescripcion.TabStop = true;
            this.rdbDescripcion.Text = "Descripción";
            this.rdbDescripcion.UseVisualStyleBackColor = true;
            this.rdbDescripcion.CheckedChanged += new System.EventHandler(this.rdbDescripcion_CheckedChanged);
            // 
            // rdbEquipo
            // 
            this.rdbEquipo.AutoSize = true;
            this.rdbEquipo.Location = new System.Drawing.Point(16, 25);
            this.rdbEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbEquipo.Name = "rdbEquipo";
            this.rdbEquipo.Size = new System.Drawing.Size(79, 19);
            this.rdbEquipo.TabIndex = 0;
            this.rdbEquipo.TabStop = true;
            this.rdbEquipo.Text = "ID Equipo";
            this.rdbEquipo.UseVisualStyleBackColor = true;
            this.rdbEquipo.CheckedChanged += new System.EventHandler(this.rdbEquipo_CheckedChanged);
            // 
            // gbxBuscarCliente
            // 
            this.gbxBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbxBuscarCliente.Controls.Add(this.dgvClientes);
            this.gbxBuscarCliente.Controls.Add(this.txtBusquedaClientes);
            this.gbxBuscarCliente.Controls.Add(this.rdbDireccion);
            this.gbxBuscarCliente.Controls.Add(this.rdbTelefono);
            this.gbxBuscarCliente.Controls.Add(this.rdbNombre);
            this.gbxBuscarCliente.Controls.Add(this.rdbIdCliente);
            this.gbxBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBuscarCliente.Location = new System.Drawing.Point(11, 180);
            this.gbxBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBuscarCliente.Name = "gbxBuscarCliente";
            this.gbxBuscarCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBuscarCliente.Size = new System.Drawing.Size(354, 189);
            this.gbxBuscarCliente.TabIndex = 12;
            this.gbxBuscarCliente.TabStop = false;
            this.gbxBuscarCliente.Text = "Buscar Cliente";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(13, 70);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(333, 103);
            this.dgvClientes.TabIndex = 5;
            this.dgvClientes.Click += new System.EventHandler(this.dgvClientes_Click);
            // 
            // txtBusquedaClientes
            // 
            this.txtBusquedaClientes.Location = new System.Drawing.Point(13, 47);
            this.txtBusquedaClientes.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusquedaClientes.Name = "txtBusquedaClientes";
            this.txtBusquedaClientes.Size = new System.Drawing.Size(310, 21);
            this.txtBusquedaClientes.TabIndex = 4;
            this.txtBusquedaClientes.TextChanged += new System.EventHandler(this.txtBusquedaClientes_TextChanged);
            // 
            // rdbDireccion
            // 
            this.rdbDireccion.AutoSize = true;
            this.rdbDireccion.Location = new System.Drawing.Point(246, 25);
            this.rdbDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDireccion.Name = "rdbDireccion";
            this.rdbDireccion.Size = new System.Drawing.Size(77, 19);
            this.rdbDireccion.TabIndex = 3;
            this.rdbDireccion.TabStop = true;
            this.rdbDireccion.Text = "Dirección";
            this.rdbDireccion.UseVisualStyleBackColor = true;
            this.rdbDireccion.CheckedChanged += new System.EventHandler(this.rdbDireccion_CheckedChanged);
            // 
            // rdbTelefono
            // 
            this.rdbTelefono.AutoSize = true;
            this.rdbTelefono.Location = new System.Drawing.Point(169, 25);
            this.rdbTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTelefono.Name = "rdbTelefono";
            this.rdbTelefono.Size = new System.Drawing.Size(73, 19);
            this.rdbTelefono.TabIndex = 2;
            this.rdbTelefono.TabStop = true;
            this.rdbTelefono.Text = "Teléfono";
            this.rdbTelefono.UseVisualStyleBackColor = true;
            this.rdbTelefono.CheckedChanged += new System.EventHandler(this.rdbTelefono_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(95, 25);
            this.rdbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(70, 19);
            this.rdbNombre.TabIndex = 1;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // rdbIdCliente
            // 
            this.rdbIdCliente.AutoSize = true;
            this.rdbIdCliente.Location = new System.Drawing.Point(13, 25);
            this.rdbIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.rdbIdCliente.Name = "rdbIdCliente";
            this.rdbIdCliente.Size = new System.Drawing.Size(78, 19);
            this.rdbIdCliente.TabIndex = 0;
            this.rdbIdCliente.TabStop = true;
            this.rdbIdCliente.Text = "ID Cliente";
            this.rdbIdCliente.UseVisualStyleBackColor = true;
            this.rdbIdCliente.CheckedChanged += new System.EventHandler(this.rdbIdCliente_CheckedChanged);
            // 
            // gbxDC
            // 
            this.gbxDC.BackColor = System.Drawing.Color.Transparent;
            this.gbxDC.Controls.Add(this.btnBuscarCliente);
            this.gbxDC.Controls.Add(this.txtDireccion);
            this.gbxDC.Controls.Add(this.txtTelefono);
            this.gbxDC.Controls.Add(this.txtNombre);
            this.gbxDC.Controls.Add(this.txtIdCliente);
            this.gbxDC.Controls.Add(this.lblDireccion);
            this.gbxDC.Controls.Add(this.lblTelefo);
            this.gbxDC.Controls.Add(this.lblnombre);
            this.gbxDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDC.Location = new System.Drawing.Point(11, 2);
            this.gbxDC.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDC.Name = "gbxDC";
            this.gbxDC.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDC.Size = new System.Drawing.Size(354, 174);
            this.gbxDC.TabIndex = 10;
            this.gbxDC.TabStop = false;
            this.gbxDC.Text = "Datos del Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCliente.Location = new System.Drawing.Point(288, 27);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(58, 28);
            this.btnBuscarCliente.TabIndex = 7;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(65, 98);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(181, 67);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Text = "";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(65, 62);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Mask = "(999) 000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 21);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 31);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 21);
            this.txtNombre.TabIndex = 4;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(65, 31);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(43, 21);
            this.txtIdCliente.TabIndex = 3;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCliente_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(2, 101);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(59, 15);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefo
            // 
            this.lblTelefo.AutoSize = true;
            this.lblTelefo.Location = new System.Drawing.Point(4, 65);
            this.lblTelefo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefo.Name = "lblTelefo";
            this.lblTelefo.Size = new System.Drawing.Size(55, 15);
            this.lblTelefo.TabIndex = 1;
            this.lblTelefo.Text = "Teléfono";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(14, 31);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(45, 15);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Cliente";
            // 
            // Proceso_de_conduces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(931, 618);
            this.Controls.Add(this.gbxEquipo);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxOpciones);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.gbxAgregar);
            this.Controls.Add(this.gbxBuscarCliente);
            this.Controls.Add(this.gbxDC);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Proceso_de_conduces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de Conduces";
            this.Load += new System.EventHandler(this.Proceso_de_conduces_Load);
            this.gbxOpciones.ResumeLayout(false);
            this.gbxDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.gbxAgregar.ResumeLayout(false);
            this.gbxAgregar.PerformLayout();
            this.gbxEquipo.ResumeLayout(false);
            this.gbxEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.gbxBuscarCliente.ResumeLayout(false);
            this.gbxBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbxDC.ResumeLayout(false);
            this.gbxDC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.Button btnPocesarConduce;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevaCond;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descipcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.GroupBox gbxAgregar;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtCanitdad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarEquipo;
        private System.Windows.Forms.TextBox txtDecrip;
        private System.Windows.Forms.TextBox txtIdEqui;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbxEquipo;
        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.TextBox txtBusquedaEquipo;
        private System.Windows.Forms.RadioButton rdbtipo;
        private System.Windows.Forms.RadioButton rdbDescripcion;
        private System.Windows.Forms.RadioButton rdbEquipo;
        private System.Windows.Forms.GroupBox gbxBuscarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtBusquedaClientes;
        private System.Windows.Forms.RadioButton rdbDireccion;
        private System.Windows.Forms.RadioButton rdbTelefono;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbIdCliente;
        private System.Windows.Forms.GroupBox gbxDC;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.RichTextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cbxEmpleado;
    }
}