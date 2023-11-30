namespace CapaPresentacion.Reportes
{
    partial class FrmRptNCEmitidas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.notasCreditoEmitidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasCreditoEmitidasTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.NotasCreditoEmitidasTableAdapter();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.notasCreditoEmitidasDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasCreditoEmitidasDetalleTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.NotasCreditoEmitidasDetalleTableAdapter();
            this.TxtParamId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasCreditoEmitidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasCreditoEmitidasDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "DS_NCEmitida";
            reportDataSource7.Value = this.notasCreditoEmitidasBindingSource;
            reportDataSource8.Name = "DS_Empresa";
            reportDataSource8.Value = this.empresaBindingSource;
            reportDataSource9.Name = "DS_NCEmitidaDetalle";
            reportDataSource9.Value = this.notasCreditoEmitidasDetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_NCEmitidas.rdlc";
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
            // notasCreditoEmitidasBindingSource
            // 
            this.notasCreditoEmitidasBindingSource.DataMember = "NotasCreditoEmitidas";
            this.notasCreditoEmitidasBindingSource.DataSource = this.dS_Reportes;
            // 
            // notasCreditoEmitidasTableAdapter
            // 
            this.notasCreditoEmitidasTableAdapter.ClearBeforeFill = true;
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
            // notasCreditoEmitidasDetalleBindingSource
            // 
            this.notasCreditoEmitidasDetalleBindingSource.DataMember = "NotasCreditoEmitidasDetalle";
            this.notasCreditoEmitidasDetalleBindingSource.DataSource = this.dS_Reportes;
            // 
            // notasCreditoEmitidasDetalleTableAdapter
            // 
            this.notasCreditoEmitidasDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // TxtParamId
            // 
            this.TxtParamId.Location = new System.Drawing.Point(350, 215);
            this.TxtParamId.Name = "TxtParamId";
            this.TxtParamId.Size = new System.Drawing.Size(100, 20);
            this.TxtParamId.TabIndex = 2;
            this.TxtParamId.Visible = false;
            // 
            // FrmRptNCEmitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtParamId);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptNCEmitidas";
            this.Text = "Impresión de Notas de Crédito Emitidas";
            this.Load += new System.EventHandler(this.FrmRptNCEmitidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasCreditoEmitidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasCreditoEmitidasDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource notasCreditoEmitidasBindingSource;
        private DS_ReportesTableAdapters.NotasCreditoEmitidasTableAdapter notasCreditoEmitidasTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.BindingSource notasCreditoEmitidasDetalleBindingSource;
        private DS_ReportesTableAdapters.NotasCreditoEmitidasDetalleTableAdapter notasCreditoEmitidasDetalleTableAdapter;
        public System.Windows.Forms.TextBox TxtParamId;
    }
}