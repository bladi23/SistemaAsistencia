using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistencia.Models
{
    public class CargoModels
    {
        public bool InsertarCargo(Controllers.CargoController cargo)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("InsertarCargo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@nombre_cargo", cargo.nombre_cargo);
                        command.Parameters.AddWithValue("@departamento_id", cargo.departamento_id);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al insertar el cargo: {ex.Message}");
                return false;
            }
        }

        public bool editarCargo(Controllers.CargoController cargo)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("editarCargo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@cargo_id", cargo.cargo_id);
                        command.Parameters.AddWithValue("@nombre_cargo", cargo.nombre_cargo);
                        command.Parameters.AddWithValue("@departamento_id", cargo.departamento_id);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al editar el cargo: {ex.Message}");
                return false;
            }
        }

        public void buscarCargos(ref DataTable dt, string buscador)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("buscarCargos", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@buscador", buscador);
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            dt.Clear(); // Limpia el DataTable antes de llenarlo
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("No se encontraron datos para los cargos.");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al mostrar los cargos: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }


    }
}
