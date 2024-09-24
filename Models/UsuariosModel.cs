using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SistemaAsistencia.Config;

namespace SistemaAsistencia.Models
{
    internal class UsuariosModel
    {
        public int usuario_id { get; set; }
        public string nombre_usuario { get; set; }
        public string contraseña { get; set; }
        public string Rol { get; set; }

        public UsuariosModel() { }

        public static UsuariosModel Insertar(UsuariosModel usuario)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO Usuarios (nombre_usuario, contraseña, rol) " +
                                   "OUTPUT INSERTED.usuario_id, INSERTED.nombre_usuario, INSERTED.contraseña, INSERTED.rol " +
                                   "VALUES (@NombreUsuario, @Password, @Roles)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NombreUsuario", usuario.nombre_usuario);
                        comando.Parameters.AddWithValue("@Password", usuario.contraseña);
                        comando.Parameters.AddWithValue("@Roles", usuario.Rol);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new UsuariosModel
                                {
                                    usuario_id = Convert.ToInt32(lector["usuario_id"]),
                                    nombre_usuario = lector["nombre_usuario"].ToString(),
                                    contraseña = lector["contraseña"].ToString(),
                                    Rol = lector["rol"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el usuario.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el usuario.");
            }
            return null;
        }

        public static string Actualizar(UsuariosModel usuario)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE Usuarios SET nombre_usuario = @NombreUsuario, contraseña = @Password, " +
                                   "rol = @Roles WHERE usuario_id = @ID";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID", usuario.usuario_id);
                        comando.Parameters.AddWithValue("@NombreUsuario", usuario.nombre_usuario);
                        comando.Parameters.AddWithValue("@Password", usuario.contraseña);
                        comando.Parameters.AddWithValue("@Roles", usuario.Rol);
                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el usuario.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el usuario.");
                return "Error";
            }
        }

        public static string Eliminar(int idUsuario)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM Usuarios WHERE usuario_id = @ID";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID", idUsuario);
                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el usuario.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el usuario.");
                return "Error";
            }
        }

        public static UsuariosModel ObtenerPorId(int idUsuario)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM Usuarios WHERE usuario_id = @ID";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID", idUsuario);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new UsuariosModel
                                {
                                    usuario_id = Convert.ToInt32(lector["usuario_id"]),
                                    nombre_usuario = lector["nombre_usuario"].ToString(),
                                    contraseña = lector["contraseña"].ToString(),
                                    Rol = lector["rol"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el usuario.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el usuario.");
            }
            return null;
        }

        public static List<UsuariosModel> ObtenerTodos()
        {
            var usuarios = new List<UsuariosModel>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM Usuarios";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                usuarios.Add(new UsuariosModel
                                {
                                    usuario_id = Convert.ToInt32(lector["usuario_id"]),
                                    nombre_usuario = lector["nombre_usuario"].ToString(),
                                    contraseña = lector["contraseña"].ToString(),
                                    Rol = lector["rol"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de usuarios.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de usuarios.");
            }

            return usuarios;
        }

        public static UsuariosModel Autenticar(string nombreUsuario, string password)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    string consulta = "SELECT * FROM Usuarios WHERE nombre_usuario = @NombreUsuario AND contraseña = @Password";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        comando.Parameters.AddWithValue("@Password", password);
                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new UsuariosModel
                                {
                                    usuario_id = Convert.ToInt32(lector["usuario_id"]),
                                    nombre_usuario = lector["nombre_usuario"].ToString(),
                                    contraseña = lector["contraseña"].ToString(),
                                    Rol = lector["rol"].ToString()
                                };
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL al autenticar el usuario: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al autenticar el usuario: " + ex.Message);
            }
        }

        public UsuariosModel OtroAutenticar(string nombreUsuario, string password)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    string consulta = "SELECT * FROM Usuarios WHERE nombre_usuario = @NombreUsuario";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                if (lector["contraseña"].ToString() == password)
                                {
                                    return new UsuariosModel
                                    {
                                        usuario_id = Convert.ToInt32(lector["usuario_id"]),
                                        nombre_usuario = lector["nombre_usuario"].ToString(),
                                        contraseña = lector["contraseña"].ToString(),
                                        Rol = lector["rol"].ToString()
                                    };
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL al autenticar el usuario: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al autenticar el usuario: " + ex.Message);
            }
        }

        


    }
}
