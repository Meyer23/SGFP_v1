﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class FrmRptListadoCompras : Form
    {
        public FrmRptListadoCompras()
        {
            InitializeComponent();
        }

        private void FrmRptListadoCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.
            dtpFechaD.Value = DateTime.Now;
            dtpFechaH.Value = DateTime.Now;
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            this.comprasListadoTableAdapter.Fill(this.dS_Reportes.ComprasListado, dtpFechaD.Value, dtpFechaH.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}