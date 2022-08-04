namespace Trabajo_final
{
    partial class BackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUp));
            this.lblBack = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btncancelarbackup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(245, 119);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(139, 18);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "Nombre del Backup";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(151, 155);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(349, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(169, 199);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(143, 59);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Hacer Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // btncancelarbackup
            // 
            this.btncancelarbackup.BackColor = System.Drawing.SystemColors.Control;
            this.btncancelarbackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelarbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarbackup.Location = new System.Drawing.Point(336, 199);
            this.btncancelarbackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancelarbackup.Name = "btncancelarbackup";
            this.btncancelarbackup.Size = new System.Drawing.Size(143, 59);
            this.btncancelarbackup.TabIndex = 3;
            this.btncancelarbackup.Text = "Cancelar";
            this.btncancelarbackup.UseVisualStyleBackColor = false;
            this.btncancelarbackup.Click += new System.EventHandler(this.btncancelarbackup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(648, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncancelarbackup);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackUp";
            this.Load += new System.EventHandler(this.BackUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btncancelarbackup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}