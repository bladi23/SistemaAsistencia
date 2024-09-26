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
                       
                        

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al insertar el personal: {ex.Message}");
                MessageBox.Show("Error al insertar el personal, el número de Indentificadión ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //public bool editarPersonal(Controllers.PersonalControlers personal)
        //{
        //    try
        //    {
        //        using (var connection = Config.Conexion.GetConnection())
        //        {
        //            using (var command = new SqlCommand("editarPersonal", connection))
        //            {
        //                command.CommandType = CommandType.StoredProcedure;
        //                command.Parameters.AddWithValue("@empleado_id", personal.empleado_id);
        //                command.Parameters.AddWithValue("@nombre", personal.nombre);
        //                command.Parameters.AddWithValue("@apellido", personal.apellido);
        //                command.Parameters.AddWithValue("@cedula", personal.cedula);
        //                command.Parameters.AddWithValue("@departamento_id", personal.departamento_id);
        //                command.Parameters.AddWithValue("@cargo_id", personal.cargo_id);
        //                command.Parameters.AddWithValue("@fecha_contratacion", personal.fecha_contratacion.Date);


        //                command.ExecuteNonQuery();
        //                return true;
        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine($"Error al editar el personal: {ex.Message}");
        //        return false;
        //    }
        //}

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

                        // Verificar y ajustar la fecha de contratación
                        DateTime fechaContratacion = personal.fecha_contratacion;
                        if (fechaContratacion < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                            fechaContratacion > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
                        {
                            fechaContratacion = DateTime.Now; // Asignar una fecha válida predeterminada
                        }
                        command.Parameters.AddWithValue("@fecha_contratacion", fechaContratacion);

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

        public void mostrarPersonal(ref DataTable dt, int desde, int hasta)
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
                            adapter.Fill(dt);
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




    

        public PersonalControlers BuscarPersonalId(int empleado_id)
        {
            PersonalControlers personal = new PersonalControlers();
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("BuscarPersonalPorId", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@empleado_id", empleado_id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                personal.empleado_id = Convert.ToInt32(reader["empleado_id"]);
                                personal.nombre = reader["nombre"].ToString();
                                personal.apellido = reader["apellido"].ToString();
                                personal.cedula = reader["cedula"].ToString();
                                personal.departamento_id = Convert.ToInt32(reader["departamento_id"]);
                                personal.nombre_departamento = reader["nombre_departamento"].ToString(); 
                                personal.cargo_id = Convert.ToInt32(reader["cargo_id"]);
                                personal.nombre_cargo = reader["nombre_cargo"].ToString();
                                personal.fecha_contratacion = Convert.ToDateTime(reader["fecha_contratacion"]);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al obtener el personal: {ex.Message}");
            }
            return personal;
        }










    }

}

