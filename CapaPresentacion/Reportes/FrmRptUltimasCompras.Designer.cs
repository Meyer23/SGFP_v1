namespace CapaPresentacion.Reportes
{
    partial class FrmRptUltimasCompras
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.ultimasComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultimasComprasTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.UltimasComprasTableAdapter();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.BtnVer = new FontAwesome.Sharp.IconButton();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultimasComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DS_UltimasCompras";
            reportDataSource5.Value = this.ultimasComprasBindingSource;
            reportDataSource6.Name = "DS_Empresa";
            reportDataSource6.Value = this.empresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_UltimasCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1122, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultimasComprasBindingSource
            // 
            this.ultimasComprasBindingSource.DataMember = "UltimasCompras";
            this.ultimasComprasBindingSource.DataSource = this.dS_Reportes;
            // 
            // ultimasComprasTableAdapter
            // 
            this.ultimasComprasTableAdapter.ClearBeforeFill = true;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.dS_Reportes;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscar.IconColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 16;
            this.BtnBuscar.Location = new System.Drawing.Point(231, 8);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 61;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(71, 12);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(155, 20);
            this.TxtProducto.TabIndex = 60;
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Location = new System.Drawing.Point(12, 15);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(53, 13);
            this.LblProducto.TabIndex = 62;
            this.LblProducto.Text = "Producto:";
            // 
            // BtnVer
            // 
            this.BtnVer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.ForeColor = System.Drawing.Color.Black;
            this.BtnVer.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnVer.IconColor = System.Drawing.Color.Black;
            this.BtnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVer.IconSize = 18;
            this.BtnVer.Location = new System.Drawing.Point(290, 8);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(93, 26);
            this.BtnVer.TabIndex = 101;
            this.BtnVer.Text = "Ver";
            this.BtnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(414, 7);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(51, 20);
            this.TxtIdProducto.TabIndex = 102;
            this.TxtIdProducto.Visible = false;
            // 
            // FrmRptUltimasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 551);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptUltimasCompras";
            this.Text = "Listado de Últimas Compras";
            this.Load += new System.EventHandler(this.FrmRptUltimasCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultimasComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource ultimasComprasBindingSource;
        private DS_ReportesTableAdapters.UltimasComprasTableAdapter ultimasComprasTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label LblProducto;
        private FontAwesome.Sharp.IconButton BtnVer;
        public System.Windows.Forms.TextBox TxtIdProducto;
    }
}