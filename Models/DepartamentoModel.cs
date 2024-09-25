using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using SistemaAsistencia.Controllers;
using SistemaAsistencia.VIEWS;


namespace SistemaAsistencia.Models
{
    public class DepartamentoModel
    {

        public bool InsertarDepartamento(Controllers.DepartamentoController departamento)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("InsertarDepartamento", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@nombre_departamento", departamento.nombre_departamento);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al insertar el departamento: {ex.Message}");
                return false;
            }
        }

        public bool EditarDepartamento(Controllers.DepartamentoController departamento)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("editarDepartamento", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@departamento_id", departamento.departamento_id);
                        command.Parameters.AddWithValue("@nombre_departamento", departamento.nombre_departamento);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al Editar el departamento: {ex.Message}");
                return false;
            }
        }

        public void buscarDepartamentos(ref DataTable dt, string buscador)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("buscarDepartamentos", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@buscador", buscador);

                        using (var adapter = new SqlDataAdapter(command))
                        {
                            // Llenar el DataTable con los datos obtenidos
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al mostrar el departamento: {ex.Message}");
            }
        }


    }
}
