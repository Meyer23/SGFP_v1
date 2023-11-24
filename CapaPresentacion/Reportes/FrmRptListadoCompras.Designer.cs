namespace CapaPresentacion.Reportes
{
    partial class FrmRptListadoCompras
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
            this.comprasListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comprasListadoTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.ComprasListadoTableAdapter();
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.BtnVer = new FontAwesome.Sharp.IconButton();
            this.LblFechaD = new System.Windows.Forms.Label();
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.LblFechaH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comprasListadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comprasListadoBindingSource
            // 
            this.comprasListadoBindingSource.DataMember = "ComprasListado";
            this.comprasListadoBindingSource.DataSource = this.dS_Reportes;
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DS_ListadoCompras";
            reportDataSource1.Value = this.comprasListadoBindingSource;
            reportDataSource2.Name = "DS_Empresa";
            reportDataSource2.Value = this.empresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_ListadoCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1181, 546);
            this.reportViewer1.TabIndex = 0;
            // 
            // comprasListadoTableAdapter
            // 
            this.comprasListadoTableAdapter.ClearBeforeFill = true;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
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
            this.BtnVer.Location = new System.Drawing.Point(405, 11);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(93, 26);
            this.BtnVer.TabIndex = 95;
            this.BtnVer.Text = "Ver";
            this.BtnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // LblFechaD
            // 
            this.LblFechaD.AutoSize = true;
            this.LblFechaD.Location = new System.Drawing.Point(12, 18);
            this.LblFechaD.Name = "LblFechaD";
            this.LblFechaD.Size = new System.Drawing.Size(74, 13);
            this.LblFechaD.TabIndex = 94;
            this.LblFechaD.Text = "Fecha Desde:";
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaD.Location = new System.Drawing.Point(92, 17);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaD.TabIndex = 96;
            // 
            // dtpFechaH
            // 
            this.dtpFechaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaH.Location = new System.Drawing.Point(289, 16);
            this.dtpFechaH.Name = "dtpFechaH";
            this.dtpFechaH.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaH.TabIndex = 98;
            // 
            // LblFechaH
            // 
            this.LblFechaH.AutoSize = true;
            this.LblFechaH.Location = new System.Drawing.Point(209, 17);
            this.LblFechaH.Name = "LblFechaH";
            this.LblFechaH.Size = new System.Drawing.Size(71, 13);
            this.LblFechaH.TabIndex = 97;
            this.LblFechaH.Text = "Fecha Hasta:";
            // 
            // FrmRptListadoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 594);
            this.Controls.Add(this.dtpFechaH);
            this.Controls.Add(this.LblFechaH);
            this.Controls.Add(this.dtpFechaD);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.LblFechaD);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptListadoCompras";
            this.Text = "Listado de Compras";
            this.Load += new System.EventHandler(this.FrmRptListadoCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comprasListadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource comprasListadoBindingSource;
        private DS_ReportesTableAdapters.ComprasListadoTableAdapter comprasListadoTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private FontAwesome.Sharp.IconButton BtnVer;
        private System.Windows.Forms.Label LblFechaD;
        private System.Windows.Forms.DateTimePicker dtpFechaD;
        private System.Windows.Forms.DateTimePicker dtpFechaH;
        private System.Windows.Forms.Label LblFechaH;
    }
}