namespace CapaPresentacion
{
    partial class FrmEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblDetalleEmpresa = new System.Windows.Forms.Label();
            this.gbEmpresa = new System.Windows.Forms.GroupBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LblLogo = new System.Windows.Forms.Label();
            this.BtnSubir = new FontAwesome.Sharp.IconButton();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.LblRUC = new System.Windows.Forms.Label();
            this.TxtDirección = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.gbEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 277);
            this.label1.TabIndex = 33;
            // 
            // LblDetalleEmpresa
            // 
            this.LblDetalleEmpresa.AutoSize = true;
            this.LblDetalleEmpresa.BackColor = System.Drawing.Color.White;
            this.LblDetalleEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleEmpresa.Location = new System.Drawing.Point(11, 24);
            this.LblDetalleEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleEmpresa.Name = "LblDetalleEmpresa";
            this.LblDetalleEmpresa.Size = new System.Drawing.Size(127, 20);
            this.LblDetalleEmpresa.TabIndex = 50;
            this.LblDetalleEmpresa.Text = "Detalle Empresa";
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.BackColor = System.Drawing.Color.White;
            this.gbEmpresa.Controls.Add(this.BtnGuardar);
            this.gbEmpresa.Controls.Add(this.TxtDirección);
            this.gbEmpresa.Controls.Add(this.LblDireccion);
            this.gbEmpresa.Controls.Add(this.TxtRUC);
            this.gbEmpresa.Controls.Add(this.LblRUC);
            this.gbEmpresa.Controls.Add(this.TxtRazonSocial);
            this.gbEmpresa.Controls.Add(this.LblRazonSocial);
            this.gbEmpresa.Controls.Add(this.BtnSubir);
            this.gbEmpresa.Controls.Add(this.LblLogo);
            this.gbEmpresa.Controls.Add(this.Logo);
            this.gbEmpresa.Location = new System.Drawing.Point(15, 57);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(501, 199);
            this.gbEmpresa.TabIndex = 51;
            this.gbEmpresa.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo.Location = new System.Drawing.Point(21, 35);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(109, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // LblLogo
            // 
            this.LblLogo.AutoSize = true;
            this.LblLogo.Location = new System.Drawing.Point(21, 16);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(31, 13);
            this.LblLogo.TabIndex = 1;
            this.LblLogo.Text = "Logo";
            // 
            // BtnSubir
            // 
            this.BtnSubir.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubir.ForeColor = System.Drawing.Color.White;
            this.BtnSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.BtnSubir.IconColor = System.Drawing.Color.White;
            this.BtnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSubir.IconSize = 16;
            this.BtnSubir.Location = new System.Drawing.Point(21, 140);
            this.BtnSubir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(109, 27);
            this.BtnSubir.TabIndex = 51;
            this.BtnSubir.Text = "Subir";
            this.BtnSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSubir.UseVisualStyleBackColor = false;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Location = new System.Drawing.Point(191, 16);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.LblRazonSocial.TabIndex = 52;
            this.LblRazonSocial.Text = "Razón Social";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(194, 33);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(268, 20);
            this.TxtRazonSocial.TabIndex = 53;
            // 
            // TxtRUC
            // 
            this.TxtRUC.Location = new System.Drawing.Point(194, 73);
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.Size = new System.Drawing.Size(268, 20);
            this.TxtRUC.TabIndex = 55;
            // 
            // LblRUC
            // 
            this.LblRUC.AutoSize = true;
            this.LblRUC.Location = new System.Drawing.Point(191, 56);
            this.LblRUC.Name = "LblRUC";
            this.LblRUC.Size = new System.Drawing.Size(30, 13);
            this.LblRUC.TabIndex = 54;
            this.LblRUC.Text = "RUC";
            // 
            // TxtDirección
            // 
            this.TxtDirección.Location = new System.Drawing.Point(194, 113);
            this.TxtDirección.Name = "TxtDirección";
            this.TxtDirección.Size = new System.Drawing.Size(268, 20);
            this.TxtDirección.TabIndex = 57;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(191, 96);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 56;
            this.LblDireccion.Text = "Dirección";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 16;
            this.BtnGuardar.Location = new System.Drawing.Point(194, 140);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(268, 27);
            this.BtnGuardar.TabIndex = 58;
            this.BtnGuardar.Text = "Guardar Cambios";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 277);
            this.Controls.Add(this.gbEmpresa);
            this.Controls.Add(this.LblDetalleEmpresa);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmpresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.gbEmpresa.ResumeLayout(false);
            this.gbEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDetalleEmpresa;
        private System.Windows.Forms.GroupBox gbEmpresa;
        private System.Windows.Forms.Label LblLogo;
        private System.Windows.Forms.PictureBox Logo;
        private FontAwesome.Sharp.IconButton BtnSubir;
        private System.Windows.Forms.TextBox TxtDirección;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.Label LblRUC;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblRazonSocial;
        private FontAwesome.Sharp.IconButton BtnGuardar;
    }
}