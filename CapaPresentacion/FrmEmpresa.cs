using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] ImageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(ImageBytes, 0, ImageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            bool obtenido = false;
            byte[] byteImage = new CN_Empresa().ObtenerLogo(out obtenido);

            if (obtenido)
            {
                Logo.Image = ByteToImage(byteImage);
            }

            Empresa empresa = new CN_Empresa().ObtenerDatos();

            TxtRazonSocial.Text = empresa.RazonSocial;
            TxtRUC.Text = empresa.RUC;
            TxtDirección.Text = empresa.Direccion;
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImage = File.ReadAllBytes(ofd.FileName);
                bool respuesta = new CN_Empresa().ActualizarLogo(byteImage, out mensaje);

                if(respuesta)
                {
                    Logo.Image = ByteToImage(byteImage);
                }
                else
                {
                    MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
