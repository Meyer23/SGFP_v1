namespace CapaPresentacion.Reportes
{
    partial class FrmRptMovimientosStock
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
            this.movimientosStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movimientosStockTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.MovimientosStockTableAdapter();
            this.movimientosStockDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movimientosStockDetalleTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.MovimientosStockDetalleTableAdapter();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.TxtParamId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosStockDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_MovimientosStock";
            reportDataSource1.Value = this.movimientosStockBindingSource;
            reportDataSource2.Name = "DS_MovimientosStockDetalle";
            reportDataSource2.Value = this.movimientosStockDetalleBindingSource;
            reportDataSource3.Name = "Ds_Empresa";
            reportDataSource3.Value = this.empresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_MovimientosStock.rdlc";
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
            // movimientosStockBindingSource
            // 
            this.movimientosStockBindingSource.DataMember = "MovimientosStock";
            this.movimientosStockBindingSource.DataSource = this.dS_Reportes;
            // 
            // movimientosStockTableAdapter
            // 
            this.movimientosStockTableAdapter.ClearBeforeFill = true;
            // 
            // movimientosStockDetalleBindingSource
            // 
            this.movimientosStockDetalleBindingSource.DataMember = "MovimientosStockDetalle";
            this.movimientosStockDetalleBindingSource.DataSource = this.dS_Reportes;
            // 
            // movimientosStockDetalleTableAdapter
            // 
            this.movimientosStockDetalleTableAdapter.ClearBeforeFill = true;
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
            this.TxtParamId.Location = new System.Drawing.Point(519, 119);
            this.TxtParamId.Name = "TxtParamId";
            this.TxtParamId.Size = new System.Drawing.Size(100, 20);
            this.TxtParamId.TabIndex = 1;
            this.TxtParamId.Visible = false;
            // 
            // FrmRptMovimientosStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtParamId);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptMovimientosStock";
            this.Text = "Impresión de MovimientosStock";
            this.Load += new System.EventHandler(this.FrmRptMovimientosStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosStockDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource movimientosStockBindingSource;
        private DS_ReportesTableAdapters.MovimientosStockTableAdapter movimientosStockTableAdapter;
        private System.Windows.Forms.BindingSource movimientosStockDetalleBindingSource;
        private DS_ReportesTableAdapters.MovimientosStockDetalleTableAdapter movimientosStockDetalleTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        public System.Windows.Forms.TextBox TxtParamId;
    }
}