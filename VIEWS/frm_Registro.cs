using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAsistencia.Models;

namespace SistemaAsistencia.VIEWS
{
    public partial class frm_Registro : Form
    {
        UsuariosModel Models = new UsuariosModel();
        System.IO.Ports.SerialPort Arduino;
        Timer refreshTimer;

        public frm_Registro()
        {
            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM3";
            Arduino.BaudRate = 9600;
            Arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Arduino_DataReceived);
            Arduino.Open();
            Arduino.Write("A");

            // Configurar el Timer
            refreshTimer = new Timer();
            refreshTimer.Interval = 2000; // Intervalo de 1 segundo
            refreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            refreshTimer.Start();
        }

        private void Arduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = Arduino.ReadLine();
                this.Invoke(new MethodInvoker(delegate
                {
                    ProcesarDatos(data);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer datos del puerto serial: " + ex.Message);
            }
        }

        private void ProcesarDatos(string data)
        {
            string[] partes = data.Split(',');
            if (partes.Length == 2)
            {
                lbl_fecha.Text = partes[0];
                lbl_Hora.Text = partes[1];
            }
            else if (data.StartsWith("ID:"))
            {
                int idHuella = Convert.ToInt32(data.Substring(3).Trim());
                string nombreYApellido = ObtenerNombreYApellidoPorId(idHuella);

                if (!string.IsNullOrEmpty(nombreYApellido))
                {
                    string[] nombres = nombreYApellido.Split(',');
                    txt_Id_Huella.Text = idHuella.ToString(); // Mostrar el ID en txt_ID
                    txt_Nombre.Text = nombres[0]; // Asumiendo que tienes un TextBox llamado txt_Nombre
                    txt_Apellido.Text = nombres[1]; // Asumiendo que tienes un TextBox llamado txt_Apellido
                    txt_Mensaje.Text = "Registro Exitoso.";
                }
                else
                {
                    txt_Mensaje.Text = "No se encontró información para el ID proporcionado.";
                }
            }
            else
            {
                txt_Mensaje.Text = data;
            }
        }

        private string ObtenerNombreYApellidoPorId(int idHuella)
        {
            // Llamar al método estático de EmpleadoosModel para obtener el nombre y apellido
            string nombreYApellido = RegistroModel.ObtenerNombreYApellidoPorId(idHuella);
            return nombreYApellido;
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            // Enviar comando para refrescar datos
            if (Arduino.IsOpen)
            {
                Arduino.Write("A");
            }
            // Limpiar los campos de texto excepto la fecha y la hora
            txt_Id_Huella.Clear();
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Mensaje.Clear();
        }

        private void frm_Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Arduino.IsOpen)
            {
                Arduino.Close();
            }
            refreshTimer.Stop();
        }
    }
}
