﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.ComponentModel;
using CapaEntidad.Models;
using System.Windows.Forms;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<UsuarioLogin> ObtenerUsuarioLogin()
        {
            List<UsuarioLogin> usuarios = new List<UsuarioLogin>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT U.LOGIN, U.PASSWORD, U.ACTIVO FROM DBO.USUARIOS U";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            usuarios.Add(new UsuarioLogin
                            {
                                Login = reader["LOGIN"].ToString(),
                                PassWord = reader["PASSWORD"].ToString(),
                                Activo = Convert.ToBoolean(reader["ACTIVO"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                   usuarios = new List<UsuarioLogin>();   
                }
            }

            return usuarios;
        }

        public List<Rol> ObtenerRol()
        {
            List<Rol> rol = new List<Rol>();


            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT R.NOMBRE, R.ESTADO FROM DBO.ROLES R WHERE R.ESTADO = 1";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rol.Add(new Rol
                            {
                                Nombre = reader["NOMBRE"].ToString(),
                                Activo = Convert.ToBoolean(reader["ESTADO"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    rol = new List<Rol>();
                }
            }

            return rol;
        }

        public List<UsuarioResponse> Listar()
        {
            List<UsuarioResponse> usuario = new List<UsuarioResponse>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "select u.id ID, e.Documento, u.Login, e.Nombres, e.Apellidos, r.Nombre as Rol, " +
                        "s.Descripcion as Sucursal, c.Descripcion as DescripcionCaja, u.Activo " +
                        "from dbo.Empleados e " +
                        "inner join dbo.Usuarios u " +
                        "on e.id = u.idEmpleado " +
                        "inner join dbo.Cajas c " +
                        "on u.idSucursalCaja = c.id " +
                        "inner join dbo.Sucursales s " +
                        "on c.idSucursal = s.id " +
                        "inner join dbo.Roles r " +
                        "on u.idRol = r.id;";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuario.Add(new UsuarioResponse
                            {
                                idUsuario = Convert.ToInt32(reader["ID"]),
                                Cedula = reader["DOCUMENTO"].ToString(),
                                Login = reader["LOGIN"].ToString(),
                                Nombres = reader["NOMBRES"].ToString(),
                                Apellidos = reader["APELLIDOS"].ToString(),
                                NombreRol = reader["ROL"].ToString(),
                                NombreSucursal = reader["SUCURSAL"].ToString(),
                                DescripcionCaja = reader["DESCRIPCIONCAJA"].ToString(),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return usuario;
        }
    }
}