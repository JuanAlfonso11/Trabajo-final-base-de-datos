namespace Trabajo_final
{
    partial class proceso_pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proceso_pagos));
            this.gbxSuplidores = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.lblbalance = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.RichTextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtNombreSuplidor = new System.Windows.Forms.TextBox();
            this.txtIDsuplidor = new System.Windows.Forms.TextBox();
            this.lblsuplidor = new System.Windows.Forms.Label();
            this.gbxDatosPago = new System.Windows.Forms.GroupBox();
            this.txtconcepto = new System.Windows.Forms.RichTextBox();
            this.lblconcepto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblmonto = new System.Windows.Forms.Label();
            this.gbxBuscarSuplidor = new System.Windows.Forms.GroupBox();
            this.rdbRNC = new System.Windows.Forms.RadioButton();
            this.dgvsuplidores = new System.Windows.Forms.DataGridView();
            this.txtBuscarSuplidor = new System.Windows.Forms.TextBox();
            this.rdbdireccion = new System.Windows.Forms.RadioButton();
            this.rdbtelefono = new System.Windows.Forms.RadioButton();
            this.rdbNombreSuplidor = new System.Windows.Forms.RadioButton();
            this.rdbIDsuplidor = new System.Windows.Forms.RadioButton();
            this.gbxopciones = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnProcesarPago = new System.Windows.Forms.Button();
            this.btnNuevoPago = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.gbxSuplidores.SuspendLayout();
            this.gbxDatosPago.SuspendLayout();
            this.gbxBuscarSuplidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsuplidores)).BeginInit();
            this.gbxopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSuplidores
            // 
            this.gbxSuplidores.Controls.Add(this.btnBuscar);
            this.gbxSuplidores.Controls.Add(this.txtbalance);
            this.gbxSuplidores.Controls.Add(this.lblbalance);
            this.gbxSuplidores.Controls.Add(this.txtdireccion);
            this.gbxSuplidores.Controls.Add(this.lbldireccion);
            this.gbxSuplidores.Controls.Add(this.txttelefono);
            this.gbxSuplidores.Controls.Add(this.lbltelefono);
            this.gbxSuplidores.Controls.Add(this.txtNombreSuplidor);
            this.gbxSuplidores.Controls.Add(this.txtIDsuplidor);
            this.gbxSuplidores.Controls.Add(this.lblsuplidor);
            this.gbxSuplidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSuplidores.Location = new System.Drawing.Point(12, 41);
            this.gbxSuplidores.Name = "gbxSuplidores";
            this.gbxSuplidores.Size = new System.Drawing.Size(430, 243);
            this.gbxSuplidores.TabIndex = 0;
            this.gbxSuplidores.TabStop = false;
            this.gbxSuplidores.Text = "Datos del Suplidor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(277, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbalance
            // 
            this.txtbalance.Location = new System.Drawing.Point(67, 202);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(164, 21);
            this.txtbalance.TabIndex = 8;
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Location = new System.Drawing.Point(9, 205);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(52, 15);
            this.lblbalance.TabIndex = 7;
            this.lblbalance.Text = "Balance";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(67, 91);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(204, 96);
            this.txtdireccion.TabIndex = 6;
            this.txtdireccion.Text = "";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(2, 91);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(59, 15);
            this.lbldireccion.TabIndex = 5;
            this.lbldireccion.Text = "Dirección";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(67, 60);
            this.txttelefono.Mask = "(999) 000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(94, 21);
            this.txttelefono.TabIndex = 4;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(6, 63);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(55, 15);
            this.lbltelefono.TabIndex = 3;
            this.lbltelefono.Text = "Teléfono";
            // 
            // txtNombreSuplidor
            // 
            this.txtNombreSuplidor.Location = new System.Drawing.Point(120, 27);
            this.txtNombreSuplidor.Name = "txtNombreSuplidor";
            this.txtNombreSuplidor.Size = new System.Drawing.Size(151, 21);
            this.txtNombreSuplidor.TabIndex = 2;
            // 
            // txtIDsuplidor
            // 
            this.txtIDsuplidor.Location = new System.Drawing.Point(67, 27);
            this.txtIDsuplidor.Name = "txtIDsuplidor";
            this.txtIDsuplidor.Size = new System.Drawing.Size(47, 21);
            this.txtIDsuplidor.TabIndex = 1;
            this.txtIDsuplidor.TextChanged += new System.EventHandler(this.txtIDsuplidor_TextChanged);
            this.txtIDsuplidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDsuplidor_KeyPress);
            // 
            // lblsuplidor
            // 
            this.lblsuplidor.AutoSize = true;
            this.lblsuplidor.Location = new System.Drawing.Point(8, 29);
            this.lblsuplidor.Name = "lblsuplidor";
            this.lblsuplidor.Size = new System.Drawing.Size(53, 15);
            this.lblsuplidor.TabIndex = 0;
            this.lblsuplidor.Text = "Suplidor";
            // 
            // gbxDatosPago
            // 
            this.gbxDatosPago.Controls.Add(this.txtconcepto);
            this.gbxDatosPago.Controls.Add(this.lblconcepto);
            this.gbxDatosPago.Controls.Add(this.txtMonto);
            this.gbxDatosPago.Controls.Add(this.lblmonto);
            this.gbxDatosPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosPago.Location = new System.Drawing.Point(448, 41);
            this.gbxDatosPago.Name = "gbxDatosPago";
            this.gbxDatosPago.Size = new System.Drawing.Size(326, 243);
            this.gbxDatosPago.TabIndex = 1;
            this.gbxDatosPago.TabStop = false;
            this.gbxDatosPago.Text = "Datos del Pago";
            // 
            // txtconcepto
            // 
            this.txtconcepto.Location = new System.Drawing.Point(71, 67);
            this.txtconcepto.Name = "txtconcepto";
            this.txtconcepto.Size = new System.Drawing.Size(195, 152);
            this.txtconcepto.TabIndex = 3;
            this.txtconcepto.Text = "";
            // 
            // lblconcepto
            // 
            this.lblconcepto.AutoSize = true;
            this.lblconcepto.Location = new System.Drawing.Point(6, 67);
            this.lblconcepto.Name = "lblconcepto";
            this.lblconcepto.Size = new System.Drawing.Size(59, 15);
            this.lblconcepto.TabIndex = 2;
            this.lblconcepto.Text = "Concepto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(71, 31);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 21);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.Location = new System.Drawing.Point(22, 34);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(42, 15);
            this.lblmonto.TabIndex = 0;
            this.lblmonto.Text = "Monto";
            // 
            // gbxBuscarSuplidor
            // 
            this.gbxBuscarSuplidor.Controls.Add(this.rdbRNC);
            this.gbxBuscarSuplidor.Controls.Add(this.dgvsuplidores);
            this.gbxBuscarSuplidor.Controls.Add(this.txtBuscarSuplidor);
            this.gbxBuscarSuplidor.Controls.Add(this.rdbdireccion);
            this.gbxBuscarSuplidor.Controls.Add(this.rdbtelefono);
            this.gbxBuscarSuplidor.Controls.Add(this.rdbNombreSuplidor);
            this.gbxBuscarSuplidor.Controls.Add(this.rdbIDsuplidor);
            this.gbxBuscarSuplidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBuscarSuplidor.Location = new System.Drawing.Point(12, 303);
            this.gbxBuscarSuplidor.Name = "gbxBuscarSuplidor";
            this.gbxBuscarSuplidor.Size = new System.Drawing.Size(762, 290);
            this.gbxBuscarSuplidor.TabIndex = 2;
            this.gbxBuscarSuplidor.TabStop = false;
            this.gbxBuscarSuplidor.Text = "Buscar Suplidor";
            // 
            // rdbRNC
            // 
            this.rdbRNC.AutoSize = true;
            this.rdbRNC.Location = new System.Drawing.Point(358, 45);
            this.rdbRNC.Name = "rdbRNC";
            this.rdbRNC.Size = new System.Drawing.Size(51, 19);
            this.rdbRNC.TabIndex = 6;
            this.rdbRNC.TabStop = true;
            this.rdbRNC.Text = "RNC";
            this.rdbRNC.UseVisualStyleBackColor = true;
            // 
            // dgvsuplidores
            // 
            this.dgvsuplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsuplidores.Location = new System.Drawing.Point(29, 104);
            this.dgvsuplidores.Name = "dgvsuplidores";
            this.dgvsuplidores.Size = new System.Drawing.Size(706, 158);
            this.dgvsuplidores.TabIndex = 5;
            this.dgvsuplidores.Click += new System.EventHandler(this.dgvsuplidores_Click);
            // 
            // txtBuscarSuplidor
            // 
            this.txtBuscarSuplidor.Location = new System.Drawing.Point(29, 68);
            this.txtBuscarSuplidor.Name = "txtBuscarSuplidor";
            this.txtBuscarSuplidor.Size = new System.Drawing.Size(380, 21);
            this.txtBuscarSuplidor.TabIndex = 4;
            this.txtBuscarSuplidor.TextChanged += new System.EventHandler(this.txtBuscarSuplidor_TextChanged);
            // 
            // rdbdireccion
            // 
            this.rdbdireccion.AutoSize = true;
            this.rdbdireccion.Location = new System.Drawing.Point(275, 45);
            this.rdbdireccion.Name = "rdbdireccion";
            this.rdbdireccion.Size = new System.Drawing.Size(77, 19);
            this.rdbdireccion.TabIndex = 3;
            this.rdbdireccion.TabStop = true;
            this.rdbdireccion.Text = "Dirección";
            this.rdbdireccion.UseVisualStyleBackColor = true;
            // 
            // rdbtelefono
            // 
            this.rdbtelefono.AutoSize = true;
            this.rdbtelefono.Location = new System.Drawing.Point(197, 45);
            this.rdbtelefono.Name = "rdbtelefono";
            this.rdbtelefono.Size = new System.Drawing.Size(73, 19);
            this.rdbtelefono.TabIndex = 2;
            this.rdbtelefono.TabStop = true;
            this.rdbtelefono.Text = "Teléfono";
            this.rdbtelefono.UseVisualStyleBackColor = true;
            // 
            // rdbNombreSuplidor
            // 
            this.rdbNombreSuplidor.AutoSize = true;
            this.rdbNombreSuplidor.Location = new System.Drawing.Point(121, 45);
            this.rdbNombreSuplidor.Name = "rdbNombreSuplidor";
            this.rdbNombreSuplidor.Size = new System.Drawing.Size(70, 19);
            this.rdbNombreSuplidor.TabIndex = 1;
            this.rdbNombreSuplidor.TabStop = true;
            this.rdbNombreSuplidor.Text = "Nombre";
            this.rdbNombreSuplidor.UseVisualStyleBackColor = true;
            // 
            // rdbIDsuplidor
            // 
            this.rdbIDsuplidor.AutoSize = true;
            this.rdbIDsuplidor.Location = new System.Drawing.Point(29, 45);
            this.rdbIDsuplidor.Name = "rdbIDsuplidor";
            this.rdbIDsuplidor.Size = new System.Drawing.Size(86, 19);
            this.rdbIDsuplidor.TabIndex = 0;
            this.rdbIDsuplidor.TabStop = true;
            this.rdbIDsuplidor.Text = "ID Suplidor";
            this.rdbIDsuplidor.UseVisualStyleBackColor = true;
            // 
            // gbxopciones
            // 
            this.gbxopciones.Controls.Add(this.btnCancelar);
            this.gbxopciones.Controls.Add(this.btnregresar);
            this.gbxopciones.Controls.Add(this.btnProcesarPago);
            this.gbxopciones.Controls.Add(this.btnNuevoPago);
            this.gbxopciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxopciones.Location = new System.Drawing.Point(780, 41);
            this.gbxopciones.Name = "gbxopciones";
            this.gbxopciones.Size = new System.Drawing.Size(149, 316);
            this.gbxopciones.TabIndex = 3;
            this.gbxopciones.TabStop = false;
            this.gbxopciones.Text = "Opciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(21, 101);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 47);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregresar.Location = new System.Drawing.Point(21, 235);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(105, 49);
            this.btnregresar.TabIndex = 2;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnProcesarPago
            // 
            this.btnProcesarPago.BackColor = System.Drawing.SystemColors.Control;
            this.btnProcesarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcesarPago.Location = new System.Drawing.Point(21, 167);
            this.btnProcesarPago.Name = "btnProcesarPago";
            this.btnProcesarPago.Size = new System.Drawing.Size(105, 49);
            this.btnProcesarPago.TabIndex = 1;
            this.btnProcesarPago.Text = "Procesar Pago";
            this.btnProcesarPago.UseVisualStyleBackColor = false;
            this.btnProcesarPago.Click += new System.EventHandler(this.btnProcesarPago_Click);
            // 
            // btnNuevoPago
            // 
            this.btnNuevoPago.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoPago.Location = new System.Drawing.Point(21, 30);
            this.btnNuevoPago.Name = "btnNuevoPago";
            this.btnNuevoPago.Size = new System.Drawing.Size(105, 49);
            this.btnNuevoPago.TabIndex = 0;
            this.btnNuevoPago.Text = "Nuevo Pago";
            this.btnNuevoPago.UseVisualStyleBackColor = false;
            this.btnNuevoPago.Click += new System.EventHandler(this.btnNuevoPago_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(777, 17);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(50, 15);
            this.lblusuario.TabIndex = 4;
            this.lblusuario.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(836, 14);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(93, 21);
            this.txtusuario.TabIndex = 5;
            // 
            // proceso_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(945, 621);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.gbxopciones);
            this.Controls.Add(this.gbxBuscarSuplidor);
            this.Controls.Add(this.gbxDatosPago);
            this.Controls.Add(this.gbxSuplidores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "proceso_pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso Pagos";
            this.Load += new System.EventHandler(this.proceso_pagos_Load);
            this.gbxSuplidores.ResumeLayout(false);
            this.gbxSuplidores.PerformLayout();
            this.gbxDatosPago.ResumeLayout(false);
            this.gbxDatosPago.PerformLayout();
            this.gbxBuscarSuplidor.ResumeLayout(false);
            this.gbxBuscarSuplidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsuplidores)).EndInit();
            this.gbxopciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSuplidores;
        private System.Windows.Forms.Label lblsuplidor;
        private System.Windows.Forms.GroupBox gbxDatosPago;
        private System.Windows.Forms.GroupBox gbxBuscarSuplidor;
        private System.Windows.Forms.GroupBox gbxopciones;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtNombreSuplidor;
        private System.Windows.Forms.TextBox txtIDsuplidor;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.RichTextBox txtdireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.RichTextBox txtconcepto;
        private System.Windows.Forms.Label lblconcepto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnProcesarPago;
        private System.Windows.Forms.Button btnNuevoPago;
        private System.Windows.Forms.DataGridView dgvsuplidores;
        private System.Windows.Forms.TextBox txtBuscarSuplidor;
        private System.Windows.Forms.RadioButton rdbdireccion;
        private System.Windows.Forms.RadioButton rdbtelefono;
        private System.Windows.Forms.RadioButton rdbNombreSuplidor;
        private System.Windows.Forms.RadioButton rdbIDsuplidor;
        private System.Windows.Forms.RadioButton rdbRNC;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
    }
}