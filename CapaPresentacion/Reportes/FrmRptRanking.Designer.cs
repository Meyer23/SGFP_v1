﻿namespace CapaPresentacion.Reportes
{
    partial class FrmRptRanking
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
            this.spRankingVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spRankingVentasProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Ranking_Ventas_ProductoTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.sp_Ranking_Ventas_ProductoTableAdapter();
            this.empresaTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.EmpresaTableAdapter();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.comboCategorias = new System.Windows.Forms.ComboBox();
            this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.LblFechaH = new System.Windows.Forms.Label();
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.LblFechaD = new System.Windows.Forms.Label();
            this.sp_Ranking_VentasTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.sp_Ranking_VentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRankingVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRankingVentasProductoBindingSource)).BeginInit();
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
            // spRankingVentasBindingSource
            // 
            this.spRankingVentasBindingSource.DataMember = "sp_Ranking_Ventas";
            this.spRankingVentasBindingSource.DataSource = this.dS_Reportes;
            // 
            // spRankingVentasProductoBindingSource
            // 
            this.spRankingVentasProductoBindingSource.DataMember = "sp_Ranking_Ventas_Producto";
            this.spRankingVentasProductoBindingSource.DataSource = this.dS_Reportes;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DS_Empresa";
            reportDataSource1.Value = this.empresaBindingSource;
            reportDataSource2.Name = "Ds_Ranking";
            reportDataSource2.Value = this.spRankingVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RPT_RankingProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1133, 551);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Ranking_Ventas_ProductoTableAdapter
            // 
            this.sp_Ranking_Ventas_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(10, 15);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(57, 13);
            this.LblCategoria.TabIndex = 95;
            this.LblCategoria.Text = "Categoría:";
            // 
            // comboCategorias
            // 
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(73, 12);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.Size = new System.Drawing.Size(220, 21);
            this.comboCategorias.TabIndex = 94;
            // 
            // dtpFechaH
            // 
            this.dtpFechaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaH.Location = new System.Drawing.Point(580, 14);
            this.dtpFechaH.Name = "dtpFechaH";
            this.dtpFechaH.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaH.TabIndex = 108;
            // 
            // LblFechaH
            // 
            this.LblFechaH.AutoSize = true;
            this.LblFechaH.Location = new System.Drawing.Point(500, 15);
            this.LblFechaH.Name = "LblFechaH";
            this.LblFechaH.Size = new System.Drawing.Size(71, 13);
            this.LblFechaH.TabIndex = 107;
            this.LblFechaH.Text = "Fecha Hasta:";
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaD.Location = new System.Drawing.Point(383, 15);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaD.TabIndex = 106;
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
            this.iconButton1.Location = new System.Drawing.Point(696, 9);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(93, 26);
            this.iconButton1.TabIndex = 105;
            this.iconButton1.Text = "Ver";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // LblFechaD
            // 
            this.LblFechaD.AutoSize = true;
            this.LblFechaD.Location = new System.Drawing.Point(303, 16);
            this.LblFechaD.Name = "LblFechaD";
            this.LblFechaD.Size = new System.Drawing.Size(74, 13);
            this.LblFechaD.TabIndex = 104;
            this.LblFechaD.Text = "Fecha Desde:";
            // 
            // sp_Ranking_VentasTableAdapter
            // 
            this.sp_Ranking_VentasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRptRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 597);
            this.Controls.Add(this.dtpFechaH);
            this.Controls.Add(this.LblFechaH);
            this.Controls.Add(this.dtpFechaD);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.LblFechaD);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.comboCategorias);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptRanking";
            this.Text = "Ranking de Ventas de Productos";
            this.Load += new System.EventHandler(this.FrmRptRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRankingVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRankingVentasProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reportes dS_Reportes;
        private System.Windows.Forms.BindingSource spRankingVentasProductoBindingSource;
        private DS_ReportesTableAdapters.sp_Ranking_Ventas_ProductoTableAdapter sp_Ranking_Ventas_ProductoTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DS_ReportesTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox comboCategorias;
        private System.Windows.Forms.DateTimePicker dtpFechaH;
        private System.Windows.Forms.Label LblFechaH;
        private System.Windows.Forms.DateTimePicker dtpFechaD;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label LblFechaD;
        private System.Windows.Forms.BindingSource spRankingVentasBindingSource;
        private DS_ReportesTableAdapters.sp_Ranking_VentasTableAdapter sp_Ranking_VentasTableAdapter;
    }
}