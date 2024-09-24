using SistemaAsistencia.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencia.Models
{
    internal class RegistroModel
    {
        // Propiedades del modelo de empleado
        public int empleado_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        // Método para obtener nombre y apellido por ID de huella
        public static string ObtenerNombreYApellidoPorId(int idHuella)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT nombre, apellido FROM Empleados WHERE empleado_id = @EmpleadoId";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@EmpleadoId", idHuella);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                // Obtener nombre y apellido
                                string nombre = lector["nombre"].ToString();
                                string apellido = lector["apellido"].ToString();

                                // Devolver el nombre y apellido concatenados o en otro formato según prefieras
                                return $"{nombre},{apellido}";
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el nombre y apellido.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el nombre y apellido.");
            }
            return null;
        }
    }
}
