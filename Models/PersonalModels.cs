using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaAsistencia.Controllers;
using System.Security.Cryptography;
using System.Security.Policy;


namespace SistemaAsistencia.Models
{
    public class PersonalModels
    {
        public bool InsertarPersonal(Controllers.PersonalControlers personal)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("InsertarPersonal", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@nombre", personal.nombre);
                        command.Parameters.AddWithValue("@apellido", personal.apellido);
                        command.Parameters.AddWithValue("@cedula", personal.cedula);
                        command.Parameters.AddWithValue("@departamento_id", personal.departamento_id);
                        command.Parameters.AddWithValue("@cargo_id", personal.cargo_id);
                        command.Parameters.AddWithValue("@fecha_contratacion", personal.fecha_contratacion);
                        command.Parameters.AddWithValue("@estado", personal.estado);
                        

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

        public bool editarPersonal(Controllers.PersonalControlers personal)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("editarPersonal", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@empleado_id", personal.empleado_id);
                        command.Parameters.AddWithValue("@nombre", personal.nombre);
                        command.Parameters.AddWithValue("@apellido", personal.apellido);
                        command.Parameters.AddWithValue("@cedula", personal.cedula);
                        command.Parameters.AddWithValue("@departamento_id", personal.departamento_id);
                        command.Parameters.AddWithValue("@cargo_id", personal.cargo_id);
                        command.Parameters.AddWithValue("@fecha_contratacion", personal.fecha_contratacion);
                       

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al editar el personal: {ex.Message}");
                return false;
            }
        }

        public bool eliminarPersonal(Controllers.PersonalControlers personal)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("eliminarPersonal", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@empleado_id", personal.empleado_id);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al eliminar el personal: {ex.Message}");
                return false;
            }
        }

        public void mostrarPersonal(DataGridView dgv, int desde, int hasta)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("mostrarPersonal", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Desde", desde);
                        command.Parameters.AddWithValue("@Hasta", hasta);

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
                Console.WriteLine($"Error al mostrar el personal: {ex.Message}");
            }
        }

        public void BuscarPersonal(DataGridView dgv, int desde, int hasta, string buscador)
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("BuscarPersonal", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Desde", desde);
                        command.Parameters.AddWithValue("@Hasta", hasta);
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
                Console.WriteLine($"Error al mostrar el personal: {ex.Message}");
            }
        }
    }

}
