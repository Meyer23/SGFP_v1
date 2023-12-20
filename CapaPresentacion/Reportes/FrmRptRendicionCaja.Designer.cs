namespace CapaPresentacion.Reportes
{
    partial class FrmRptRendicionCaja
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
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.rendicionCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.rendicionCajaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.RendicionCajaTableAdapter();
            this.TxtParamLogin = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtParamCaja = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendicionCajaBindingSource)).BeginInit();
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
            // rendicionCajaBindingSource
            // 
            this.rendicionCajaBindingSource.DataMember = "RendicionCaja";
            this.rendicionCajaBindingSource.DataSource = this.dS_Reportes;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Empresa";
            reportDataSource1.Value = this.empresaBindingSource;
            reportDataSource2.Name = "DS_Rendicion";
            reportDataSource2.Value = this.rendicionCajaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_RendicionCaja.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // rendicionCajaTableAdapter
            // 
            this.rendicionCajaTableAdapter.ClearBeforeFill = true;
            // 
            // TxtParamLogin
            // 
            this.TxtParamLogin.Location = new System.Drawing.Point(350, 127);
            this.TxtParamLogin.Name = "TxtParamLogin";
            this.TxtParamLogin.Size = new System.Drawing.Size(100, 20);
            this.TxtParamLogin.TabIndex = 2;
            this.TxtParamLogin.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Visible = false;
            // 
            // TxtParamCaja
            // 
            this.TxtParamCaja.Location = new System.Drawing.Point(350, 215);
            this.TxtParamCaja.Name = "TxtParamCaja";
            this.TxtParamCaja.Size = new System.Drawing.Size(100, 20);
            this.TxtParamCaja.TabIndex = 4;
            this.TxtParamCaja.Visible = false;
            // 
            // FrmRptRendicionCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtParamCaja);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtParamLogin);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptRendicionCaja";
            this.Text = "Rendicion de Caja";
            this.Load += new System.EventHandler(this.FrmRptRendicionCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendicionCajaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.BindingSource rendicionCajaBindingSource;
        private DS_ReportesTableAdapters.RendicionCajaTableAdapter rendicionCajaTableAdapter;
        public System.Windows.Forms.TextBox TxtParamLogin;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox TxtParamCaja;
    }
}