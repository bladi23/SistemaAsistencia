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
                        command.Parameters.AddWithValue("@", departamento.nombre_departamento);
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
                    using (var command = new SqlCommand("editarPersonal", connection))
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
                Console.WriteLine($"Error al insertar el personal: {ex.Message}");
                return false;
            }
        }

        public void BuscarDepartamento(DataGridView dgv,  string buscador)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("BuscarPersonal", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Buscador", buscador);



                        using (var adapter = new SqlDataAdapter(command))
                        {
                            using (var table = new DataTable())
                            {
                                adapter.Fill(table);
                                dgv.DataSource = table;
                            }
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
