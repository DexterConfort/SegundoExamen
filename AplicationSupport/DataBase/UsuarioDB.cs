using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace DataBase
{
    public class UsuarioDB
    {
        string cadena = "server=localhost; user=root; database=solicitudes; password=123456";
        public Usuario Autenticacion(Login login)
        {
            Usuario usuario = null;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuario WHERE (CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena);");

                using (MySqlConnection conexion = new MySqlConnection(cadena))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.Usuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = login.Contrasena;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            usuario = new Usuario();
                            usuario.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            usuario.Nombre = dr["Nombre"].ToString();
                            usuario.Contrasena = dr["Contrasena"].ToString();
                            usuario.Correo = dr["Correo"].ToString();
                            usuario.Rol = dr["Rol"].ToString();
                            if (dr["Foto"].GetType() != typeof(DBNull))
                            {
                                usuario.Foto = (byte[])dr["Foto"];
                            }
                            usuario.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                            usuario.Estado = Convert.ToBoolean(dr["Estado"]);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return usuario;
        }
        public bool Insertar(Usuario user)
        {
            Boolean inserto = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO usuario VALUES ");
                sql.Append(" (@CodigoUsuario, @Nombre, @Contrasena, @Correo, @Rol, @Foto, @FechaCreacion, @Estado); ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {

                        comando.CommandType = CommandType.Text;

                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.Contrasena;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = user.FechaCreacion;
                        comando.Parameters.Add("@Estado", MySqlDbType.Bit).Value = user.Estado;
                        comando.ExecuteNonQuery();
                        inserto = true;


                    }
                }
            }
            catch (System.Exception ex)
            {
            }

            return inserto;
        }

        public Boolean Editar(Usuario user)
        {
            Boolean edito = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE usuario SET ");
                //donde esta el campo le paso el parametro 
                //El CodigoUsuario como es una llave primaria no se puede modificar// El campo CodigoUsuario no lo ponemos
                sql.Append(" Nombre = @Nombre, Contrasena = @Contrasena, Correo = @Correo, Rol = @Rol, Foto = @Foto, Estado = @Estado ");
                sql.Append(" WHERE CodigoUsuario =  @CodigoUsuario; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;

                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.Contrasena;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
                        comando.Parameters.Add("@Estado", MySqlDbType.Bit).Value = user.Estado;
                        comando.ExecuteNonQuery();
                        edito = true;


                    }

                }
            }
            catch (System.Exception ex)
            {
            }
            return edito;
        }

        public bool Eliminar(string codigoUsuario)
        {
            bool elimino = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM usuario ");
                sql.Append(" WHERE CodigoUsuario =  @CodigoUsuario; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;

                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
                        comando.ExecuteNonQuery();
                        elimino = true;


                    }

                }
            }
            catch (System.Exception ex)
            {
            }
            return elimino;



















        }

        public DataTable DevolverUsuarios()
        {
            DataTable dt = new DataTable();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuario ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);


                    }

                }
            }
            catch (System.Exception ex)
            {
            }
            return dt;


        }


        public byte[] DevolverFoto(string codigoUsuario)
        {
            byte[] foto = new byte[0];

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT Foto FROM usuario WHERE CodigoUsuario = @CodigoUsuario;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;

                        comando.Parameters.Add("CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
                        MySqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            foto = (byte[])dr["Foto"];
                        }


                    }



                }
            }
            catch (System.Exception ex)
            {
            }

            return foto;

        }
    }
}
