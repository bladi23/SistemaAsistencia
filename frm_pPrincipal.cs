using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SistemaAsistencia.VIEWS
{
    public partial class frm_pPrincipal : Form
    {
        private SerialPort serialPort;
        public frm_pPrincipal()
        {
            InitializeComponent();
            InicializarConexionSerial();
            

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

            serialPort.DataReceived += new SerialDataReceivedEventHandler(DatosRecibidos);
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



        private void DatosRecibidos(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine();
                // Procesar los datos recibidos del Arduino
                string[] datos = data.Split(',');

                if (datos.Length >= 2)
                {
                    // Asignar el primer elemento del array al lbl_fecha
                    this.Invoke(new MethodInvoker(delegate
                    {
                        lbl_fecha.Text = datos[0];
                        lbl_hora.Text = datos[1];
                    }));
                }
            }
            catch (TimeoutException) { }
        }

        private void btn_menuPrincipal_Click(object sender, EventArgs e)
        {
            frm_Login  _frm_Login = new frm_Login();
            _frm_Login.Show();
            serialPort.Close();
            this.Hide();

        }

    
    }
}
