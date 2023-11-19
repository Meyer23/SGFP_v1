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
    public partial class FrmRptProductos : Form
    {
        public FrmRptProductos()
        {
            InitializeComponent();
        }

        private void FrmRptProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.dS_Reportes.Productos);

            this.reportViewer1.RefreshReport();
        }
    }
}