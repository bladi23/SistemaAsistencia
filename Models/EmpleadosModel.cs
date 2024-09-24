using SistemaAsistencia.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaAsistencia.Models
{
    internal class EmpleadosModel
    {
        public int empleados_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public int departamento_id { get; set; }
        public int cargo_id { get; set; }
        public DateTime fecha_contratacion { get; set; }
        public string estado { get; set; }
        public string nombre_departamento { get; set; } // Añadido
        public string nombre_cargo { get; set; } // Añadido

        // Constructor vacío
        public EmpleadosModel() { }

        // Constructor con parámetros
        public EmpleadosModel(int empleados_id, string nombre, string apellido, string cedula, int departamento_id, int cargo_id, DateTime fecha_contratacion, string estado)
        {
            this.empleados_id = empleados_id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.departamento_id = departamento_id;
            this.cargo_id = cargo_id;
            this.fecha_contratacion = fecha_contratacion;
            this.estado = estado;
        }

        public static List<EmpleadosModel> Buscar(int desde, int hasta, string buscador)
        {
            var listaEmpleados = new List<EmpleadosModel>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = @"
                        SELECT e.empleados_id, e.nombre, e.apellido, e.cedula, e.departamento_id, e.cargo_id, e.fecha_contratacion, e.estado,
                               d.nombre AS nombre_departamento, c.nombre AS nombre_cargo
                        FROM Empleados e
                        JOIN Departamentos d ON e.departamento_id = d.departamento_id
                        JOIN Cargos c ON e.cargo_id = c.cargo_id
                        WHERE (e.nombre LIKE @Buscador OR e.apellido LIKE @Buscador OR e.cedula LIKE @Buscador)
                        ORDER BY e.empleados_id
                        OFFSET @Desde ROWS FETCH NEXT @Hasta ROWS ONLY";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Desde", desde);
                        comando.Parameters.AddWithValue("@Hasta", hasta);
                        comando.Parameters.AddWithValue("@Buscador", $"%{buscador}%");

                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var empleado = new EmpleadosModel
                                {
                                    empleados_id = Convert.ToInt32(lector["empleados_id"]),
                                    nombre = lector["nombre"].ToString(),
                                    apellido = lector["apellido"].ToString(),
                                    cedula = lector["cedula"].ToString(),
                                    departamento_id = Convert.ToInt32(lector["departamento_id"]),
                                    cargo_id = Convert.ToInt32(lector["cargo_id"]),
                                    fecha_contratacion = Convert.ToDateTime(lector["fecha_contratacion"]),
                                    estado = lector["estado"].ToString(),
                                    nombre_departamento = lector["nombre_departamento"].ToString(),
                                    nombre_cargo = lector["nombre_cargo"].ToString()
                                };
                                listaEmpleados.Add(empleado);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al buscar empleados.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al buscar empleados.");
            }

            return listaEmpleados;
        }

        public static EmpleadosModel Insertar(EmpleadosModel empleado)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = @"
                        INSERT INTO Empleados (nombre, apellido, cedula, departamento_id, cargo_id, fecha_contratacion, estado) 
                        OUTPUT INSERTED.empleados_id, INSERTED.nombre, INSERTED.apellido, INSERTED.cedula, INSERTED.departamento_id, INSERTED.cargo_id, INSERTED.fecha_contratacion, INSERTED.estado 
                        VALUES (@Nombre, @Apellido, @Cedula, @DepartamentoId, @CargoId, @FechaContratacion, @Estado)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", empleado.nombre);
                        comando.Parameters.AddWithValue("@Apellido", empleado.apellido);
                        comando.Parameters.AddWithValue("@Cedula", empleado.cedula);
                        comando.Parameters.AddWithValue("@DepartamentoId", empleado.departamento_id);
                        comando.Parameters.AddWithValue("@CargoId", empleado.cargo_id);
                        comando.Parameters.AddWithValue("@FechaContratacion", empleado.fecha_contratacion);
                        comando.Parameters.AddWithValue("@Estado", empleado.estado);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new EmpleadosModel
                                {
                                    empleados_id = Convert.ToInt32(lector["empleados_id"]),
                                    nombre = lector["nombre"].ToString(),
                                    apellido = lector["apellido"].ToString(),
                                    cedula = lector["cedula"].ToString(),
                                    departamento_id = Convert.ToInt32(lector["departamento_id"]),
                                    cargo_id = Convert.ToInt32(lector["cargo_id"]),
                                    fecha_contratacion = Convert.ToDateTime(lector["fecha_contratacion"]),
                                    estado = lector["estado"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el empleado.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el empleado.");
            }
            return null;
        }

        // Método para editar un empleado
        public static bool Editar(EmpleadosModel empleado)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = @"
                        EXEC [dbo].[editarPersonal] 
                        @empleado_id, 
                        @nombre, 
                        @apellido, 
                        @cedula, 
                        @departamento_id, 
                        @cargo_id, 
                        @fecha_contratacion";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@empleado_id", empleado.empleados_id);
                        comando.Parameters.AddWithValue("@nombre", empleado.nombre);
                        comando.Parameters.AddWithValue("@apellido", empleado.apellido);
                        comando.Parameters.AddWithValue("@cedula", empleado.cedula);
                        comando.Parameters.AddWithValue("@departamento_id", empleado.departamento_id);
                        comando.Parameters.AddWithValue("@cargo_id", empleado.cargo_id);
                        comando.Parameters.AddWithValue("@fecha_contratacion", empleado.fecha_contratacion);

                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al editar el empleado.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al editar el empleado.");
            }
            return false;
        }

        // Método para eliminar un empleado
        public static bool Eliminar(int empleado_id)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = @"
                        EXEC [dbo].[eliminarPersonal] 
                        @empleado_id";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@empleado_id", empleado_id);

                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el empleado.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el empleado.");
            }
            return false;
        }
    }
}
