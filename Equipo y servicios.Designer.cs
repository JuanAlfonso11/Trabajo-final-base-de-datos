namespace Trabajo_final
{
    partial class Equipo_y_servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipo_y_servicios));
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.lblEquipo_Servicio = new System.Windows.Forms.Label();
            this.gbxOpciones = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.chkDiponibilidad = new System.Windows.Forms.CheckBox();
            this.chkServicio = new System.Windows.Forms.CheckBox();
            this.gbxListadoEquipos = new System.Windows.Forms.GroupBox();
            this.rdbCantidad = new System.Windows.Forms.RadioButton();
            this.rdbTipo = new System.Windows.Forms.RadioButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rdbServicio = new System.Windows.Forms.RadioButton();
            this.rdbDisponibilidad = new System.Windows.Forms.RadioButton();
            this.rdbDescripcion = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.lblCriterios = new System.Windows.Forms.Label();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxOpciones.SuspendLayout();
            this.gbxListadoEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(95, 28);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(19, 15);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(36, 59);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(11, 87);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(103, 15);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio del equipo";
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(21, 122);
            this.lblDisponibilidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(86, 15);
            this.lblDisponibilidad.TabIndex = 3;
            this.lblDisponibilidad.Text = "Disponibilidad";
            // 
            // lblEquipo_Servicio
            // 
            this.lblEquipo_Servicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEquipo_Servicio.AutoSize = true;
            this.lblEquipo_Servicio.Location = new System.Drawing.Point(59, 154);
            this.lblEquipo_Servicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipo_Servicio.Name = "lblEquipo_Servicio";
            this.lblEquipo_Servicio.Size = new System.Drawing.Size(50, 15);
            this.lblEquipo_Servicio.TabIndex = 4;
            this.lblEquipo_Servicio.Text = "Servicio";
            // 
            // gbxOpciones
            // 
            this.gbxOpciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxOpciones.Controls.Add(this.btnBuscar);
            this.gbxOpciones.Controls.Add(this.btnRegresar);
            this.gbxOpciones.Controls.Add(this.btnEliminar);
            this.gbxOpciones.Controls.Add(this.btnGuardar);
            this.gbxOpciones.Controls.Add(this.btnNuevo);
            this.gbxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOpciones.Location = new System.Drawing.Point(416, 118);
            this.gbxOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Name = "gbxOpciones";
            this.gbxOpciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOpciones.Size = new System.Drawing.Size(208, 148);
            this.gbxOpciones.TabIndex = 14;
            this.gbxOpciones.TabStop = false;
            this.gbxOpciones.Text = "Opciones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(104, 62);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 37);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Location = new System.Drawing.Point(5, 103);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(193, 33);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(5, 62);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 37);
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
            this.btnGuardar.Location = new System.Drawing.Point(104, 21);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 37);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(4, 21);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 37);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(123, 25);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(61, 21);
            this.txtID.TabIndex = 15;
            this.txtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcion.Location = new System.Drawing.Point(123, 56);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(211, 21);
            this.txtDescripcion.TabIndex = 16;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtprecio
            // 
            this.txtprecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprecio.Location = new System.Drawing.Point(123, 87);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(76, 21);
            this.txtprecio.TabIndex = 17;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // chkDiponibilidad
            // 
            this.chkDiponibilidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkDiponibilidad.AutoSize = true;
            this.chkDiponibilidad.Location = new System.Drawing.Point(123, 122);
            this.chkDiponibilidad.Margin = new System.Windows.Forms.Padding(2);
            this.chkDiponibilidad.Name = "chkDiponibilidad";
            this.chkDiponibilidad.Size = new System.Drawing.Size(56, 19);
            this.chkDiponibilidad.TabIndex = 18;
            this.chkDiponibilidad.Text = "Si/No";
            this.chkDiponibilidad.UseVisualStyleBackColor = true;
            this.chkDiponibilidad.CheckedChanged += new System.EventHandler(this.chkDiponibilidad_CheckedChanged);
            // 
            // chkServicio
            // 
            this.chkServicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkServicio.AutoSize = true;
            this.chkServicio.Location = new System.Drawing.Point(123, 154);
            this.chkServicio.Margin = new System.Windows.Forms.Padding(2);
            this.chkServicio.Name = "chkServicio";
            this.chkServicio.Size = new System.Drawing.Size(56, 19);
            this.chkServicio.TabIndex = 19;
            this.chkServicio.Text = "Si/No";
            this.chkServicio.UseVisualStyleBackColor = true;
            this.chkServicio.CheckedChanged += new System.EventHandler(this.chkServicio_CheckedChanged);
            // 
            // gbxListadoEquipos
            // 
            this.gbxListadoEquipos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxListadoEquipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxListadoEquipos.Controls.Add(this.rdbCantidad);
            this.gbxListadoEquipos.Controls.Add(this.rdbTipo);
            this.gbxListadoEquipos.Controls.Add(this.txtBusqueda);
            this.gbxListadoEquipos.Controls.Add(this.rdbServicio);
            this.gbxListadoEquipos.Controls.Add(this.rdbDisponibilidad);
            this.gbxListadoEquipos.Controls.Add(this.rdbDescripcion);
            this.gbxListadoEquipos.Controls.Add(this.rdbID);
            this.gbxListadoEquipos.Controls.Add(this.lblCriterios);
            this.gbxListadoEquipos.Controls.Add(this.dgvEquipos);
            this.gbxListadoEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListadoEquipos.Location = new System.Drawing.Point(32, 288);
            this.gbxListadoEquipos.Margin = new System.Windows.Forms.Padding(2);
            this.gbxListadoEquipos.Name = "gbxListadoEquipos";
            this.gbxListadoEquipos.Padding = new System.Windows.Forms.Padding(2);
            this.gbxListadoEquipos.Size = new System.Drawing.Size(611, 230);
            this.gbxListadoEquipos.TabIndex = 20;
            this.gbxListadoEquipos.TabStop = false;
            this.gbxListadoEquipos.Text = "Listado de Equipos";
            // 
            // rdbCantidad
            // 
            this.rdbCantidad.AutoSize = true;
            this.rdbCantidad.Location = new System.Drawing.Point(507, 27);
            this.rdbCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCantidad.Name = "rdbCantidad";
            this.rdbCantidad.Size = new System.Drawing.Size(74, 19);
            this.rdbCantidad.TabIndex = 8;
            this.rdbCantidad.TabStop = true;
            this.rdbCantidad.Text = "Cantidad";
            this.rdbCantidad.UseVisualStyleBackColor = true;
            this.rdbCantidad.CheckedChanged += new System.EventHandler(this.rdbCantidad_CheckedChanged);
            // 
            // rdbTipo
            // 
            this.rdbTipo.AutoSize = true;
            this.rdbTipo.Location = new System.Drawing.Point(454, 27);
            this.rdbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTipo.Name = "rdbTipo";
            this.rdbTipo.Size = new System.Drawing.Size(49, 19);
            this.rdbTipo.TabIndex = 7;
            this.rdbTipo.TabStop = true;
            this.rdbTipo.Text = "Tipo";
            this.rdbTipo.UseVisualStyleBackColor = true;
            this.rdbTipo.CheckedChanged += new System.EventHandler(this.rdbTipo_CheckedChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(4, 60);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(587, 21);
            this.txtBusqueda.TabIndex = 6;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // rdbServicio
            // 
            this.rdbServicio.AutoSize = true;
            this.rdbServicio.Location = new System.Drawing.Point(382, 27);
            this.rdbServicio.Margin = new System.Windows.Forms.Padding(2);
            this.rdbServicio.Name = "rdbServicio";
            this.rdbServicio.Size = new System.Drawing.Size(68, 19);
            this.rdbServicio.TabIndex = 5;
            this.rdbServicio.TabStop = true;
            this.rdbServicio.Text = "Servicio";
            this.rdbServicio.UseVisualStyleBackColor = true;
            this.rdbServicio.CheckedChanged += new System.EventHandler(this.rdbServicio_CheckedChanged);
            // 
            // rdbDisponibilidad
            // 
            this.rdbDisponibilidad.AutoSize = true;
            this.rdbDisponibilidad.Location = new System.Drawing.Point(274, 27);
            this.rdbDisponibilidad.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDisponibilidad.Name = "rdbDisponibilidad";
            this.rdbDisponibilidad.Size = new System.Drawing.Size(104, 19);
            this.rdbDisponibilidad.TabIndex = 4;
            this.rdbDisponibilidad.TabStop = true;
            this.rdbDisponibilidad.Text = "Disponibilidad";
            this.rdbDisponibilidad.UseVisualStyleBackColor = true;
            this.rdbDisponibilidad.CheckedChanged += new System.EventHandler(this.rdbDisponibilidad_CheckedChanged);
            // 
            // rdbDescripcion
            // 
            this.rdbDescripcion.AutoSize = true;
            this.rdbDescripcion.Location = new System.Drawing.Point(180, 27);
            this.rdbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDescripcion.Name = "rdbDescripcion";
            this.rdbDescripcion.Size = new System.Drawing.Size(90, 19);
            this.rdbDescripcion.TabIndex = 3;
            this.rdbDescripcion.TabStop = true;
            this.rdbDescripcion.Text = "Descripción";
            this.rdbDescripcion.UseVisualStyleBackColor = true;
            this.rdbDescripcion.CheckedChanged += new System.EventHandler(this.rdbDescripcion_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(139, 27);
            this.rdbID.Margin = new System.Windows.Forms.Padding(2);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(37, 19);
            this.rdbID.TabIndex = 2;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // lblCriterios
            // 
            this.lblCriterios.AutoSize = true;
            this.lblCriterios.Location = new System.Drawing.Point(4, 29);
            this.lblCriterios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCriterios.Name = "lblCriterios";
            this.lblCriterios.Size = new System.Drawing.Size(131, 15);
            this.lblCriterios.TabIndex = 1;
            this.lblCriterios.Text = "Criterios de Búsqueda:";
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(4, 83);
            this.dgvEquipos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.RowHeadersWidth = 51;
            this.dgvEquipos.RowTemplate.Height = 24;
            this.dgvEquipos.Size = new System.Drawing.Size(587, 142);
            this.dgvEquipos.TabIndex = 0;
            this.dgvEquipos.Click += new System.EventHandler(this.dgvEquipos_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(208, 28);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 15);
            this.lblTipo.TabIndex = 21;
            this.lblTipo.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTipo.Location = new System.Drawing.Point(248, 25);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(86, 21);
            this.txtTipo.TabIndex = 22;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.chkServicio);
            this.groupBox1.Controls.Add(this.chkDiponibilidad);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblEquipo_Servicio);
            this.groupBox1.Controls.Add(this.lblDisponibilidad);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(353, 181);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del equipo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 77);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento de Equipos y Servicios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(571, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Equipo_y_servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(693, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxListadoEquipos);
            this.Controls.Add(this.gbxOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Equipo_y_servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiendo de Equipos y Servicios";
            this.Load += new System.EventHandler(this.Equipo_y_servicios_Load);
            this.gbxOpciones.ResumeLayout(false);
            this.gbxListadoEquipos.ResumeLayout(false);
            this.gbxListadoEquipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.Label lblEquipo_Servicio;
        private System.Windows.Forms.GroupBox gbxOpciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.CheckBox chkDiponibilidad;
        private System.Windows.Forms.CheckBox chkServicio;
        private System.Windows.Forms.GroupBox gbxListadoEquipos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rdbServicio;
        private System.Windows.Forms.RadioButton rdbDisponibilidad;
        private System.Windows.Forms.RadioButton rdbDescripcion;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.Label lblCriterios;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.RadioButton rdbTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}