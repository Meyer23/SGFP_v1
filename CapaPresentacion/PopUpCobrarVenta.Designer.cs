namespace CapaPresentacion
{
    partial class PopUpCobrarVenta
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
            this.detallePagoGroup = new System.Windows.Forms.GroupBox();
            this.LblNroDocumento = new System.Windows.Forms.Label();
            this.TxtNroDocumento = new System.Windows.Forms.TextBox();
            this.LblVuelto = new System.Windows.Forms.Label();
            this.TxtVuelto = new System.Windows.Forms.TextBox();
            this.LblMontoTotal = new System.Windows.Forms.Label();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.LbLFormaPago = new System.Windows.Forms.Label();
            this.BtnFinalizar = new FontAwesome.Sharp.IconButton();
            this.BtnPreview = new FontAwesome.Sharp.IconButton();
            this.ChkCredito = new System.Windows.Forms.CheckBox();
            this.ChkEfectivo = new System.Windows.Forms.CheckBox();
            this.detallePagoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // detallePagoGroup
            // 
            this.detallePagoGroup.Controls.Add(this.ChkEfectivo);
            this.detallePagoGroup.Controls.Add(this.ChkCredito);
            this.detallePagoGroup.Controls.Add(this.LblNroDocumento);
            this.detallePagoGroup.Controls.Add(this.TxtNroDocumento);
            this.detallePagoGroup.Controls.Add(this.LblVuelto);
            this.detallePagoGroup.Controls.Add(this.TxtVuelto);
            this.detallePagoGroup.Controls.Add(this.LblMontoTotal);
            this.detallePagoGroup.Controls.Add(this.TxtMontoTotal);
            this.detallePagoGroup.Controls.Add(this.LbLFormaPago);
            this.detallePagoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detallePagoGroup.Location = new System.Drawing.Point(24, 31);
            this.detallePagoGroup.Name = "detallePagoGroup";
            this.detallePagoGroup.Size = new System.Drawing.Size(771, 246);
            this.detallePagoGroup.TabIndex = 0;
            this.detallePagoGroup.TabStop = false;
            this.detallePagoGroup.Text = "Detalle";
            // 
            // LblNroDocumento
            // 
            this.LblNroDocumento.AutoSize = true;
            this.LblNroDocumento.Location = new System.Drawing.Point(309, 180);
            this.LblNroDocumento.Name = "LblNroDocumento";
            this.LblNroDocumento.Size = new System.Drawing.Size(159, 25);
            this.LblNroDocumento.TabIndex = 7;
            this.LblNroDocumento.Text = "Nro. Documento:";
            // 
            // TxtNroDocumento
            // 
            this.TxtNroDocumento.Location = new System.Drawing.Point(531, 175);
            this.TxtNroDocumento.Name = "TxtNroDocumento";
            this.TxtNroDocumento.Size = new System.Drawing.Size(156, 30);
            this.TxtNroDocumento.TabIndex = 6;
            // 
            // LblVuelto
            // 
            this.LblVuelto.AutoSize = true;
            this.LblVuelto.Location = new System.Drawing.Point(526, 26);
            this.LblVuelto.Name = "LblVuelto";
            this.LblVuelto.Size = new System.Drawing.Size(74, 25);
            this.LblVuelto.TabIndex = 5;
            this.LblVuelto.Text = "Vuelto:";
            // 
            // TxtVuelto
            // 
            this.TxtVuelto.Location = new System.Drawing.Point(531, 82);
            this.TxtVuelto.Name = "TxtVuelto";
            this.TxtVuelto.Size = new System.Drawing.Size(156, 30);
            this.TxtVuelto.TabIndex = 4;
            // 
            // LblMontoTotal
            // 
            this.LblMontoTotal.AutoSize = true;
            this.LblMontoTotal.Location = new System.Drawing.Point(309, 26);
            this.LblMontoTotal.Name = "LblMontoTotal";
            this.LblMontoTotal.Size = new System.Drawing.Size(73, 25);
            this.LblMontoTotal.TabIndex = 3;
            this.LblMontoTotal.Text = "Monto:";
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.Location = new System.Drawing.Point(312, 84);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.Size = new System.Drawing.Size(156, 30);
            this.TxtMontoTotal.TabIndex = 2;
            // 
            // LbLFormaPago
            // 
            this.LbLFormaPago.AutoSize = true;
            this.LbLFormaPago.Location = new System.Drawing.Point(13, 43);
            this.LbLFormaPago.Name = "LbLFormaPago";
            this.LbLFormaPago.Size = new System.Drawing.Size(146, 25);
            this.LbLFormaPago.TabIndex = 1;
            this.LbLFormaPago.Text = "Forma de Pago";
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.Green;
            this.BtnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinalizar.ForeColor = System.Drawing.Color.White;
            this.BtnFinalizar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnFinalizar.IconColor = System.Drawing.Color.White;
            this.BtnFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFinalizar.Location = new System.Drawing.Point(629, 317);
            this.BtnFinalizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(166, 95);
            this.BtnFinalizar.TabIndex = 70;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            // 
            // BtnPreview
            // 
            this.BtnPreview.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPreview.ForeColor = System.Drawing.Color.White;
            this.BtnPreview.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnPreview.IconColor = System.Drawing.Color.White;
            this.BtnPreview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPreview.Location = new System.Drawing.Point(442, 317);
            this.BtnPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(166, 95);
            this.BtnPreview.TabIndex = 71;
            this.BtnPreview.Text = "Pre Visualizar";
            this.BtnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPreview.UseVisualStyleBackColor = false;
            // 
            // ChkCredito
            // 
            this.ChkCredito.AutoSize = true;
            this.ChkCredito.Location = new System.Drawing.Point(37, 141);
            this.ChkCredito.Name = "ChkCredito";
            this.ChkCredito.Size = new System.Drawing.Size(101, 29);
            this.ChkCredito.TabIndex = 8;
            this.ChkCredito.Text = "Credito";
            this.ChkCredito.UseVisualStyleBackColor = true;
            // 
            // ChkEfectivo
            // 
            this.ChkEfectivo.AutoSize = true;
            this.ChkEfectivo.Location = new System.Drawing.Point(37, 84);
            this.ChkEfectivo.Name = "ChkEfectivo";
            this.ChkEfectivo.Size = new System.Drawing.Size(107, 29);
            this.ChkEfectivo.TabIndex = 9;
            this.ChkEfectivo.Text = "Efectivo";
            this.ChkEfectivo.UseVisualStyleBackColor = true;
            // 
            // PopUpCobrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 441);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.detallePagoGroup);
            this.Name = "PopUpCobrarVenta";
            this.Text = "Cobrar Venta";
            this.detallePagoGroup.ResumeLayout(false);
            this.detallePagoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detallePagoGroup;
        private System.Windows.Forms.Label LbLFormaPago;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        private System.Windows.Forms.Label LblVuelto;
        private System.Windows.Forms.TextBox TxtVuelto;
        private System.Windows.Forms.Label LblMontoTotal;
        private FontAwesome.Sharp.IconButton BtnFinalizar;
        private FontAwesome.Sharp.IconButton BtnPreview;
        private System.Windows.Forms.Label LblNroDocumento;
        private System.Windows.Forms.TextBox TxtNroDocumento;
        private System.Windows.Forms.CheckBox ChkEfectivo;
        private System.Windows.Forms.CheckBox ChkCredito;
    }
}