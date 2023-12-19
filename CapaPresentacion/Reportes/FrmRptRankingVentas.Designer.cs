namespace CapaPresentacion.Reportes
{
    partial class FrmRptRankingVentas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.spRankingVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Ranking_VentasTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.sp_Ranking_VentasTableAdapter();
            this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.LblFechaH = new System.Windows.Forms.Label();
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.LblFechaD = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.comboCategorias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRankingVentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource7.Name = "DS_Empresa";
            reportDataSource7.Value = this.empresaBindingSource;
            reportDataSource8.Name = "DS_Ranking_Ventas";
            reportDataSource8.Value = this.spRankingVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_RankingVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1128, 493);
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
            // spRankingVentasBindingSource
            // 
            this.spRankingVentasBindingSource.DataMember = "sp_Ranking_Ventas";
            this.spRankingVentasBindingSource.DataSource = this.dS_Reportes;
            // 
            // sp_Ranking_VentasTableAdapter
            // 
            this.sp_Ranking_VentasTableAdapter.ClearBeforeFill = true;
            // 
            // dtpFechaH
            // 
            this.dtpFechaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaH.Location = new System.Drawing.Point(585, 14);
            this.dtpFechaH.Name = "dtpFechaH";
            this.dtpFechaH.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaH.TabIndex = 115;
            // 
            // LblFechaH
            // 
            this.LblFechaH.AutoSize = true;
            this.LblFechaH.Location = new System.Drawing.Point(505, 15);
            this.LblFechaH.Name = "LblFechaH";
            this.LblFechaH.Size = new System.Drawing.Size(71, 13);
            this.LblFechaH.TabIndex = 114;
            this.LblFechaH.Text = "Fecha Hasta:";
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaD.Location = new System.Drawing.Point(388, 15);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaD.TabIndex = 113;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(701, 9);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(93, 26);
            this.iconButton1.TabIndex = 112;
            this.iconButton1.Text = "Ver";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // LblFechaD
            // 
            this.LblFechaD.AutoSize = true;
            this.LblFechaD.Location = new System.Drawing.Point(308, 16);
            this.LblFechaD.Name = "LblFechaD";
            this.LblFechaD.Size = new System.Drawing.Size(74, 13);
            this.LblFechaD.TabIndex = 111;
            this.LblFechaD.Text = "Fecha Desde:";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(15, 15);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(57, 13);
            this.LblCategoria.TabIndex = 110;
            this.LblCategoria.Text = "Categoría:";
            // 
            // comboCategorias
            // 
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(78, 12);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.Size = new System.Drawing.Size(220, 21);
            this.comboCategorias.TabIndex = 109;
            // 
            // FrmRptRankingVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 538);
            this.Controls.Add(this.dtpFechaH);
            this.Controls.Add(this.LblFechaH);
            this.Controls.Add(this.dtpFechaD);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.LblFechaD);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.comboCategorias);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptRankingVentas";
            this.Text = "Ranking de Ventas de Productos";
            this.Load += new System.EventHandler(this.FrmRptRankingVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRankingVentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.BindingSource spRankingVentasBindingSource;
        private DS_ReportesTableAdapters.sp_Ranking_VentasTableAdapter sp_Ranking_VentasTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFechaH;
        private System.Windows.Forms.Label LblFechaH;
        private System.Windows.Forms.DateTimePicker dtpFechaD;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label LblFechaD;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox comboCategorias;
    }
}