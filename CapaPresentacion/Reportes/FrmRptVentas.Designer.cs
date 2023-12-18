namespace CapaPresentacion.Reportes
{
    partial class FrmRptVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.ventasTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.VentasTableAdapter();
            this.ventasDetalleTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.VentasDetalleTableAdapter();
            this.TxtParamId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.dS_Reportes;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.dS_Reportes;
            // 
            // ventasDetalleBindingSource
            // 
            this.ventasDetalleBindingSource.DataMember = "VentasDetalle";
            this.ventasDetalleBindingSource.DataSource = this.dS_Reportes;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Empresa";
            reportDataSource1.Value = this.empresaBindingSource;
            reportDataSource2.Name = "DS_Ventas";
            reportDataSource2.Value = this.ventasBindingSource;
            reportDataSource3.Name = "DS_VentasDetalles";
            reportDataSource3.Value = this.ventasDetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_Ventas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(843, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // ventasDetalleTableAdapter
            // 
            this.ventasDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // TxtParamId
            // 
            this.TxtParamId.Location = new System.Drawing.Point(350, 215);
            this.TxtParamId.Name = "TxtParamId";
            this.TxtParamId.Size = new System.Drawing.Size(100, 20);
            this.TxtParamId.TabIndex = 2;
            this.TxtParamId.Visible = false;
            // 
            // FrmRptVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.TxtParamId);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptVentas";
            this.Text = "FrmRptVentas";
            this.Load += new System.EventHandler(this.FrmRptVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private System.Windows.Forms.BindingSource ventasDetalleBindingSource;
        private DS_ReportesTableAdapters.VentasTableAdapter ventasTableAdapter;
        private DS_ReportesTableAdapters.VentasDetalleTableAdapter ventasDetalleTableAdapter;
        public System.Windows.Forms.TextBox TxtParamId;
    }
}