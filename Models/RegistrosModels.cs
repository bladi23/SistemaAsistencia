using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaAsistencia.Models
{
    internal class RegistrosModels
    {
        public int empleado_id { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora_entrada { get; set; }
        public DateTime hora_salida { get; set; }



        public DataTable CargarDatosAsistencias()
        {
            DataTable dtAsistencias = new DataTable();
            using (var connection = Config.Conexion.GetConnection())
            {
                string query = @"
            SELECT 
                CONCAT(e.nombre, ' ', e.apellido) AS nombre_completo, 
                e.cedula, 
                ra.fecha, 
                ra.hora_entrada, 
                ra.hora_salida 
            FROM RegistroAsistencias ra
            INNER JOIN Empleados e ON ra.empleado_id = e.empleado_id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dtAsistencias.Load(reader);
                    }
                }
            }
            return dtAsistencias;
        }

    }
}
