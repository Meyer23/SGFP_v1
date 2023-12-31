﻿using CapaDatos;
using CapaEntidad;
using CapaEntidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuarios cd_usuario = new CD_Usuarios();

        public List<UsuarioLogin> ObtenerUsuario()
        {
            return cd_usuario.ObtenerUsuarioLogin();
        }

        public List<Rol> ObtenerRol()
        {
            return cd_usuario.ObtenerRol().ToList();
        }

        public List<UsuarioResponse> Listar()
        {
            return cd_usuario.Listar();
        }

        public int Registrar(UsuarioRequest obj, out string Mensaje)
        {
            return cd_usuario.Registrar(obj, out Mensaje);
        }

        public bool Editar(UsuarioEditarRequest obj, out string Mensaje)
        {
            return cd_usuario.Editar(obj, out Mensaje);
        }
    }
}