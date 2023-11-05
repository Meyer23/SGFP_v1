using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_TiposDocumentos
    {
        private CD_TiposDocumentos cd_tipoDocumento = new CD_TiposDocumentos();

        public List<TipoDocumento> Listar()
        {
            return cd_tipoDocumento.Listar();
        }

        public int Registrar(TipoDocumento obj, out string Mensaje)
        {
            return cd_tipoDocumento.Registrar(obj, out Mensaje);
        }

        public bool Editar(TipoDocumento obj, out string Mensaje)
        {
            return cd_tipoDocumento.Editar(obj, out Mensaje);
        }

        public List<TipoDocumento> ObtenerTiposDocumentos()
        {
            return cd_tipoDocumento.ObtenerTiposDocumentos();
        }

        public bool InsertarFormasPago(int idTipoDoc)
        {
            return cd_tipoDocumento.InsertarFormasPago(idTipoDoc);
        }

        public bool EditarFormasPago(int IdTipoDoc, int IdFormaPago, bool Acepta)
        {
            return cd_tipoDocumento.EditarFormasPago(IdTipoDoc, IdFormaPago, Acepta);
        }

        //public List<TipoDocFormaPago> ObtenerFormasPago(int idTipoDoc)
        //{
        //    return cd_tipoDocumento.ObtenerFormasPago(idTipoDoc);
        //}

        public List<TipoDocFormaPago> ListarFormasPago(int idTipoDoc)
        {
            return cd_tipoDocumento.ListarFormasPago(idTipoDoc);
        }
    }
}
