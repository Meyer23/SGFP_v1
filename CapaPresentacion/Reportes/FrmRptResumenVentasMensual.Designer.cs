namespace CapaPresentacion.Reportes
{
    partial class FrmRptResumenVentasMensual
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
            this.resumenVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resumenVentasTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.ResumenVentasTableAdapter();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.resumenVentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.LblFechaH = new System.Windows.Forms.Label();
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.BtnVer = new FontAwesome.Sharp.IconButton();
            this.LblFechaD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenVentasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DS_Empresa";
            reportDataSource5.Value = this.empresaBindingSource;
            reportDataSource6.Name = "DS_ResumenVentasMensual";
            reportDataSource6.Value = this.resumenVentasBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_ResumenVentasMensual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1127, 516);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resumenVentasBindingSource
            // 
            this.resumenVentasBindingSource.DataMember = "ResumenVentas";
            this.resumenVentasBindingSource.DataSource = this.dS_Reportes;
            // 
            // resumenVentasTableAdapter
            // 
            this.resumenVentasTableAdapter.ClearBeforeFill = true;
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
            // resumenVentasBindingSource1
            // 
            this.resumenVentasBindingSource1.DataMember = "ResumenVentas";
            this.resumenVentasBindingSource1.DataSource = this.dS_Reportes;
            // 
            // dtpFechaH
            // 
            this.dtpFechaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaH.Location = new System.Drawing.Point(289, 7);
            this.dtpFechaH.Name = "dtpFechaH";
            this.dtpFechaH.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaH.TabIndex = 113;
            // 
            // LblFechaH
            // 
            this.LblFechaH.AutoSize = true;
            this.LblFechaH.Location = new System.Drawing.Point(209, 8);
            this.LblFechaH.Name = "LblFechaH";
            this.LblFechaH.Size = new System.Drawing.Size(71, 13);
            this.LblFechaH.TabIndex = 112;
            this.LblFechaH.Text = "Fecha Hasta:";
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaD.Location = new System.Drawing.Point(92, 8);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaD.TabIndex = 111;
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
            this.BtnVer.Location = new System.Drawing.Point(405, 2);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(93, 26);
            this.BtnVer.TabIndex = 110;
            this.BtnVer.Text = "Ver";
            this.BtnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // LblFechaD
            // 
            this.LblFechaD.AutoSize = true;
            this.LblFechaD.Location = new System.Drawing.Point(12, 9);
            this.LblFechaD.Name = "LblFechaD";
            this.LblFechaD.Size = new System.Drawing.Size(74, 13);
            this.LblFechaD.TabIndex = 109;
            this.LblFechaD.Text = "Fecha Desde:";
            // 
            // FrmRptResumenVentasMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 553);
            this.Controls.Add(this.dtpFechaH);
            this.Controls.Add(this.LblFechaH);
            this.Controls.Add(this.dtpFechaD);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.LblFechaD);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptResumenVentasMensual";
            this.Text = "Resumen de Ventas";
            this.Load += new System.EventHandler(this.FrmRptResumenVentasMensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenVentasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource resumenVentasBindingSource;
        private DS_ReportesTableAdapters.ResumenVentasTableAdapter resumenVentasTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.BindingSource resumenVentasBindingSource1;
        private System.Windows.Forms.DateTimePicker dtpFechaH;
        private System.Windows.Forms.Label LblFechaH;
        private System.Windows.Forms.DateTimePicker dtpFechaD;
        private FontAwesome.Sharp.IconButton BtnVer;
        private System.Windows.Forms.Label LblFechaD;
    }
}