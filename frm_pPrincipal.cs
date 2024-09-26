using System;
using System.Data.SqlClient;
using System.Data;
using System.IO.Ports;
using System.Windows.Forms;

namespace SistemaAsistencia.VIEWS
{
    public partial class frm_pPrincipal : Form
    {
        private SerialPort serialPort;
        private Timer timerBlanqueo;

        public frm_pPrincipal()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_pPrincipal_FormClosing); // Suscribirse al evento FormClosing
        }

        private void frm_pPrincipal_Load(object sender, EventArgs e)
        {
            InicializarConexionSerial();
            serialPort.Write("A");
        }

        private void InicializarConexionSerial()
        {
            serialPort = new SerialPort
            {
                PortName = "COM3", // Cambia esto al puerto correcto donde está conectado tu Arduino
                BaudRate = 9600, // Asegúrate de que coincida con la configuración de tu Arduino
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None,
                ReadTimeout = 500,
                WriteTimeout = 500
            };

            serialPort.DataReceived += DatosRecibidos;

            try
            {
                serialPort.Open();
                //MessageBox.Show("Conexión con Arduino establecida.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con Arduino: {ex.Message}");
            }
        }

      


        private void IniciarTimerLimpieza()
        {
            #region
            Timer timerLimpieza = new Timer();
            timerLimpieza.Interval = 5000; // Intervalo en milisegundos (5000 ms = 5 segundos)
            timerLimpieza.Tick += (s, e) =>
            {
                // Limpiar los cuadros de texto
                txt_IdHuella.Text = string.Empty;
                txt_Mensaje.Text = string.Empty;
                txt_apellidos.Text = string.Empty;
                txt_nombres.Text = string.Empty;

                timerLimpieza.Stop(); // Detener el timer después de usarlo
                timerLimpieza.Dispose(); // Liberar recursos
            };
            timerLimpieza.Start(); // Iniciar el timer de limpieza
            #endregion
        }

        private void DatosRecibidos(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine();
                // Procesar los datos recibidos del Arduino
                string[] datos = data.Split(',');

                if (datos.Length >= 4)
                {
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        lbl_fecha.Text = datos[0];      // Mostrar fecha
                        lbl_hora.Text = datos[1];       // Mostrar hora
                        txt_IdHuella.Text = datos[2];   // Mostrar ID de la huella
                        txt_Mensaje.Text = datos[3];    // Mostrar mensaje

                        int idHuella = Convert.ToInt32(datos[2]);
                        //VerificarEmpleado(idHuella);
                        RegistrarAsistencia(idHuella);
                        IniciarTimerLimpieza();

                    }));
                }
                else if (datos.Length == 2)
                {
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        lbl_fecha.Text = datos[0];      // Mostrar fecha
                        lbl_hora.Text = datos[1];       // Mostrar hora
                    }));
                }
            }
            catch (TimeoutException)
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    txt_Mensaje.Text = "Error: Tiempo de espera agotado"; // Mensaje de error
                }));
            }
            catch (Exception ex)
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    txt_Mensaje.Text = $"Error: {ex.Message}"; // Mensaje de error
                }));
            }
        }




        //private void RegistrarAsistencia(int idHuella)
        //{
        //    SqlConnection connection = null;
        //    try
        //    {
        //        connection = Config.Conexion.GetConnection();

        //        // Verificar el empleado
        //        string queryEmpleado = "SELECT empleado_id, nombre, apellido FROM Empleados WHERE empleado_id = @idHuella";
        //        using (SqlCommand commandEmpleado = new SqlCommand(queryEmpleado, connection))
        //        {
        //            commandEmpleado.Parameters.AddWithValue("@idHuella", idHuella);
        //            using (SqlDataReader reader = commandEmpleado.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    int empleadoId = reader.GetInt32(0);
        //                    string nombre = reader.GetString(1);
        //                    string apellido = reader.GetString(2);

        //                    txt_Mensaje.Text = $"Empleado encontrado: {empleadoId}";
        //                    txt_nombres.Text = nombre;
        //                    txt_apellidos.Text = apellido;

        //                    // Insertar registro de asistencia
        //                    reader.Close(); // Cerrar el reader antes de ejecutar otro comando

        //                    string queryAsistencia;
        //                    DateTime horaActual = DateTime.Now;

        //                    // Verificar si ya existe un registro de entrada o salida para el mismo día
        //                    string queryVerificacion = "SELECT COUNT(*) FROM RegistroAsistencias WHERE empleado_id = @empleado_id AND fecha = @fecha";
        //                    using (SqlCommand commandVerificacion = new SqlCommand(queryVerificacion, connection))
        //                    {
        //                        commandVerificacion.Parameters.AddWithValue("@empleado_id", empleadoId);
        //                        commandVerificacion.Parameters.AddWithValue("@fecha", DateTime.Now.Date);

        //                        int count = (int)commandVerificacion.ExecuteScalar();
        //                        if (count > 0)
        //                        {
        //                            txt_Mensaje.Text = "Ya se ha registrado la entrada o salida para hoy.";
        //                            return;
        //                        }
        //                    }

        //                    if (horaActual.TimeOfDay >= new TimeSpan(7, 0, 0) && horaActual.TimeOfDay <= new TimeSpan(7, 30, 0))
        //                    {
        //                        queryAsistencia = "INSERT INTO RegistroAsistencias (empleado_id, fecha, hora_entrada) VALUES (@empleado_id, @fecha, @hora)";
        //                    }
        //                    else if (horaActual.TimeOfDay >= new TimeSpan(17, 0, 0) && horaActual.TimeOfDay <= new TimeSpan(17, 30, 0))
        //                    {
        //                        queryAsistencia = "UPDATE RegistroAsistencias SET hora_salida = @hora WHERE empleado_id = @empleado_id AND fecha = @fecha";
        //                    }
        //                    else
        //                    {
        //                        txt_Mensaje.Text = "Fuera del horario de registro permitido";
        //                        return;
        //                    }

        //                    using (SqlCommand commandAsistencia = new SqlCommand(queryAsistencia, connection))
        //                    {
        //                        commandAsistencia.Parameters.AddWithValue("@empleado_id", empleadoId);
        //                        commandAsistencia.Parameters.AddWithValue("@fecha", DateTime.Now.Date);
        //                        commandAsistencia.Parameters.AddWithValue("@hora", horaActual);

        //                        commandAsistencia.ExecuteNonQuery();
        //                        txt_Mensaje.Text = "Asistencia registrada correctamente";
        //                    }
        //                }
        //                else
        //                {
        //                    txt_Mensaje.Text = "Empleado no encontrado";
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        txt_Mensaje.Text = $"Error al registrar asistencia: {ex.Message}";
        //    }
        //    finally
        //    {
        //        if (connection != null && connection.State == ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        private void RegistrarAsistencia(int idHuella)
        {
            SqlConnection connection = null;
            try
            {
                connection = Config.Conexion.GetConnection();

                // Verificar el empleado
                string queryEmpleado = "SELECT empleado_id, nombre, apellido FROM Empleados WHERE empleado_id = @idHuella";
                using (SqlCommand commandEmpleado = new SqlCommand(queryEmpleado, connection))
                {
                    commandEmpleado.Parameters.AddWithValue("@idHuella", idHuella);
                    using (SqlDataReader reader = commandEmpleado.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int empleadoId = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string apellido = reader.GetString(2);

                            txt_Mensaje.Text = $"Empleado encontrado: {empleadoId}";
                            txt_nombres.Text = nombre;
                            txt_apellidos.Text = apellido;

                            // Insertar registro de asistencia
                            reader.Close(); // Cerrar el reader antes de ejecutar otro comando

                            string queryAsistencia;
                            DateTime horaActual = DateTime.Now;

                            if (horaActual.TimeOfDay >= new TimeSpan(7, 0, 0) && horaActual.TimeOfDay <= new TimeSpan(7, 30, 0))
                            {
                                // Verificar si ya existe un registro de entrada para el mismo día
                                string queryVerificacion = "SELECT COUNT(*) FROM RegistroAsistencias WHERE empleado_id = @empleado_id AND fecha = @fecha AND hora_entrada IS NOT NULL";
                                using (SqlCommand commandVerificacion = new SqlCommand(queryVerificacion, connection))
                                {
                                    commandVerificacion.Parameters.AddWithValue("@empleado_id", empleadoId);
                                    commandVerificacion.Parameters.AddWithValue("@fecha", DateTime.Now.Date);

                                    int count = (int)commandVerificacion.ExecuteScalar();
                                    if (count > 0)
                                    {
                                        txt_Mensaje.Text = "Ya se ha registrado la entrada para hoy.";
                                        return;
                                    }
                                }

                                queryAsistencia = "INSERT INTO RegistroAsistencias (empleado_id, fecha, hora_entrada) VALUES (@empleado_id, @fecha, @hora)";
                            }
                            else if (horaActual.TimeOfDay >= new TimeSpan(17, 0, 0) && horaActual.TimeOfDay <= new TimeSpan(17, 30, 0))
                            {
                                // Verificar si ya existe un registro de salida para el mismo día
                                string queryVerificacion = "SELECT COUNT(*) FROM RegistroAsistencias WHERE empleado_id = @empleado_id AND fecha = @fecha AND hora_salida IS NOT NULL";
                                using (SqlCommand commandVerificacion = new SqlCommand(queryVerificacion, connection))
                                {
                                    commandVerificacion.Parameters.AddWithValue("@empleado_id", empleadoId);
                                    commandVerificacion.Parameters.AddWithValue("@fecha", DateTime.Now.Date);

                                    int count = (int)commandVerificacion.ExecuteScalar();
                                    if (count > 0)
                                    {
                                        txt_Mensaje.Text = "Ya se ha registrado la salida para hoy.";
                                        return;
                                    }
                                }

                                queryAsistencia = "UPDATE RegistroAsistencias SET hora_salida = @hora WHERE empleado_id = @empleado_id AND fecha = @fecha";
                            }
                            else
                            {
                                txt_Mensaje.Text = "Fuera del horario de registro permitido";
                                return;
                            }

                            using (SqlCommand commandAsistencia = new SqlCommand(queryAsistencia, connection))
                            {
                                commandAsistencia.Parameters.AddWithValue("@empleado_id", empleadoId);
                                commandAsistencia.Parameters.AddWithValue("@fecha", DateTime.Now.Date);
                                commandAsistencia.Parameters.AddWithValue("@hora", horaActual);

                                commandAsistencia.ExecuteNonQuery();
                                txt_Mensaje.Text = "Asistencia registrada correctamente";
                            }
                        }
                        else
                        {
                            txt_Mensaje.Text = "Empleado no encontrado";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txt_Mensaje.Text = $"Error al registrar asistencia: {ex.Message}";
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }




        private void btn_menuPrincipal_Click(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.Show();
            CerrarConexionSerial();  // Cierra el puerto serial
            this.Hide();
        }

        private void CerrarConexionSerial()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                // Desuscribirse del evento para evitar problemas al cerrar
                serialPort.DataReceived -= DatosRecibidos;
                serialPort.Close();
                serialPort.Dispose();
            }
        }

        // Evento FormClosing para cerrar la conexión serial de manera segura cuando se cierra el formulario
        private void frm_pPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarConexionSerial();  // Cierra el puerto serial antes de cerrar el formulario
            Application.Exit();

        }

        
    }
}
