namespace CapaPresentacion.Reportes
{
    partial class FrmRptProductos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboCategorias = new System.Windows.Forms.ComboBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.BtnVer = new FontAwesome.Sharp.IconButton();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.ProductosTableAdapter();
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DS_Reporte_Productos";
            reportDataSource1.Value = this.productosBindingSource;
            reportDataSource2.Name = "DS_Reporte_Empresa";
            reportDataSource2.Value = this.empresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboCategorias
            // 
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(75, 17);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.Size = new System.Drawing.Size(220, 21);
            this.comboCategorias.TabIndex = 1;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(12, 20);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(57, 13);
            this.LblCategoria.TabIndex = 2;
            this.LblCategoria.Text = "Categoría:";
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
            this.BtnVer.Location = new System.Drawing.Point(314, 13);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(93, 26);
            this.BtnVer.TabIndex = 93;
            this.BtnVer.Text = "Ver";
            this.BtnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.dS_Reportes;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.dS_Reportes;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRptProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.comboCategorias);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptProductos";
            this.Text = "Listado de Existencia";
            this.Load += new System.EventHandler(this.FrmRptProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DS_ReportesTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.ComboBox comboCategorias;
        private System.Windows.Forms.Label LblCategoria;
        private FontAwesome.Sharp.IconButton BtnVer;
    }
}