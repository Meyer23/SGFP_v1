namespace CapaPresentacion.Reportes
{
    partial class FrmRptListadoNCEmitidas
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
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.nCEmitidasListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nCEmitidasListadoTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.NCEmitidasListadoTableAdapter();
            this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.LblFechaH = new System.Windows.Forms.Label();
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.BtnVer = new FontAwesome.Sharp.IconButton();
            this.LblFechaD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCEmitidasListadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DS_Empresa";
            reportDataSource5.Value = this.empresaBindingSource;
            reportDataSource6.Name = "DS_NCEmitidaListado";
            reportDataSource6.Value = this.nCEmitidasListadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_ListadoNCEmitida.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1250, 571);
            this.reportViewer1.TabIndex = 0;
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
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // nCEmitidasListadoBindingSource
            // 
            this.nCEmitidasListadoBindingSource.DataMember = "NCEmitidasListado";
            this.nCEmitidasListadoBindingSource.DataSource = this.dS_Reportes;
            // 
            // nCEmitidasListadoTableAdapter
            // 
            this.nCEmitidasListadoTableAdapter.ClearBeforeFill = true;
            // 
            // dtpFechaH
            // 
            this.dtpFechaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaH.Location = new System.Drawing.Point(289, 18);
            this.dtpFechaH.Name = "dtpFechaH";
            this.dtpFechaH.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaH.TabIndex = 108;
            // 
            // LblFechaH
            // 
            this.LblFechaH.AutoSize = true;
            this.LblFechaH.Location = new System.Drawing.Point(209, 19);
            this.LblFechaH.Name = "LblFechaH";
            this.LblFechaH.Size = new System.Drawing.Size(71, 13);
            this.LblFechaH.TabIndex = 107;
            this.LblFechaH.Text = "Fecha Hasta:";
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaD.Location = new System.Drawing.Point(92, 19);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaD.TabIndex = 106;
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
            this.BtnVer.Location = new System.Drawing.Point(405, 13);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(93, 26);
            this.BtnVer.TabIndex = 105;
            this.BtnVer.Text = "Ver";
            this.BtnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // LblFechaD
            // 
            this.LblFechaD.AutoSize = true;
            this.LblFechaD.Location = new System.Drawing.Point(12, 20);
            this.LblFechaD.Name = "LblFechaD";
            this.LblFechaD.Size = new System.Drawing.Size(74, 13);
            this.LblFechaD.TabIndex = 104;
            this.LblFechaD.Text = "Fecha Desde:";
            // 
            // FrmRptListadoNCEmitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 618);
            this.Controls.Add(this.dtpFechaH);
            this.Controls.Add(this.LblFechaH);
            this.Controls.Add(this.dtpFechaD);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.LblFechaD);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptListadoNCEmitidas";
            this.Text = "Listado de Notas de Crédito Emitidas";
            this.Load += new System.EventHandler(this.FrmRptListadoNCEmitidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCEmitidasListadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.BindingSource nCEmitidasListadoBindingSource;
        private DS_ReportesTableAdapters.NCEmitidasListadoTableAdapter nCEmitidasListadoTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFechaH;
        private System.Windows.Forms.Label LblFechaH;
        private System.Windows.Forms.DateTimePicker dtpFechaD;
        private FontAwesome.Sharp.IconButton BtnVer;
        private System.Windows.Forms.Label LblFechaD;
    }
}