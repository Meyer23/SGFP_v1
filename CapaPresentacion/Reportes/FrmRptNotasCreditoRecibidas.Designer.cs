namespace CapaPresentacion.Reportes
{
    partial class FrmRptNotasCreditoRecibidas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.notasCreditoRecibidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasCreditoRecibidasTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.NotasCreditoRecibidasTableAdapter();
            this.notasCreditoRecibidasDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasCreditoRecibidasDetalleTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.NotasCreditoRecibidasDetalleTableAdapter();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.TxtParamId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasCreditoRecibidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasCreditoRecibidasDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_NCRecibida";
            reportDataSource1.Value = this.notasCreditoRecibidasBindingSource;
            reportDataSource2.Name = "DS_NCRecibidaDetalle";
            reportDataSource2.Value = this.notasCreditoRecibidasDetalleBindingSource;
            reportDataSource3.Name = "DS_Empresa";
            reportDataSource3.Value = this.empresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_NotasCreditoRecibidas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasCreditoRecibidasBindingSource
            // 
            this.notasCreditoRecibidasBindingSource.DataMember = "NotasCreditoRecibidas";
            this.notasCreditoRecibidasBindingSource.DataSource = this.dS_Reportes;
            // 
            // notasCreditoRecibidasTableAdapter
            // 
            this.notasCreditoRecibidasTableAdapter.ClearBeforeFill = true;
            // 
            // notasCreditoRecibidasDetalleBindingSource
            // 
            this.notasCreditoRecibidasDetalleBindingSource.DataMember = "NotasCreditoRecibidasDetalle";
            this.notasCreditoRecibidasDetalleBindingSource.DataSource = this.dS_Reportes;
            // 
            // notasCreditoRecibidasDetalleTableAdapter
            // 
            this.notasCreditoRecibidasDetalleTableAdapter.ClearBeforeFill = true;
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
            // TxtParamId
            // 
            this.TxtParamId.Location = new System.Drawing.Point(430, 147);
            this.TxtParamId.Name = "TxtParamId";
            this.TxtParamId.Size = new System.Drawing.Size(100, 20);
            this.TxtParamId.TabIndex = 1;
            this.TxtParamId.Visible = false;
            // 
            // FrmRptNotasCreditoRecibidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtParamId);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptNotasCreditoRecibidas";
            this.Text = "FrmRptNotasCreditoRecibidas";
            this.Load += new System.EventHandler(this.FrmRptNotasCreditoRecibidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasCreditoRecibidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasCreditoRecibidasDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource notasCreditoRecibidasBindingSource;
        private DS_ReportesTableAdapters.NotasCreditoRecibidasTableAdapter notasCreditoRecibidasTableAdapter;
        private System.Windows.Forms.BindingSource notasCreditoRecibidasDetalleBindingSource;
        private DS_ReportesTableAdapters.NotasCreditoRecibidasDetalleTableAdapter notasCreditoRecibidasDetalleTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        public System.Windows.Forms.TextBox TxtParamId;
    }
}