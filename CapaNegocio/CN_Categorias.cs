using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categorias
    {
        private CD_Categorias cd_categoria = new CD_Categorias();

        public List<Categoria> Listar()
        {
            return cd_categoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            return cd_categoria.Registrar(obj, out Mensaje);
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            return cd_categoria.Editar(obj, out Mensaje);
        }
    }
}
