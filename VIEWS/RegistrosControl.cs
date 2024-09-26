using SistemaAsistencia.Controllers;
using SistemaAsistencia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistencia.VIEWS
{
    public partial class RegistrosControl : UserControl
    {
        public RegistrosControl()
        {
            InitializeComponent();
        }

        private void RegistrosControl_Load(object sender, EventArgs e)
        {

        }

        public void CargarDatosAsistencias()
        {
            RegistrosController registrosController = new RegistrosController();
            // Cargar los datos de asistencia desde el controlador
            DataTable dtAsistencias = registrosController.CargarDatosAsistencias();

            // Asignar los datos al DataGridView
            dgv_RegistrosAsistencias.DataSource = dtAsistencias;



            DisenodvtRegistros();
        }

        private void DisenodvtRegistros()
        {
            // Ajustar el tamaño de las columnas en horizontal
            dgv_RegistrosAsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn column in dgv_RegistrosAsistencias.Columns)
            {
                column.Width = 260; // Ajusta el tamaño de las columnas en píxeles
            }

            // Ajustar el tamaño de las filas en vertical
            dgv_RegistrosAsistencias.RowTemplate.Height = 100;

            // Establecer color de fondo
            dgv_RegistrosAsistencias.BackgroundColor = Color.FromArgb(169, 169, 169);

            // Ocultar encabezado de fila
            dgv_RegistrosAsistencias.RowHeadersVisible = false;

            // Deshabilitar estilos visuales del encabezado
            dgv_RegistrosAsistencias.EnableHeadersVisualStyles = false;

            // Quitar borde del DataGridView
            dgv_RegistrosAsistencias.BorderStyle = BorderStyle.None;

            // Configurar estilo de borde de las celdas
            dgv_RegistrosAsistencias.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // Configurar estilo de borde del encabezado de columna
            dgv_RegistrosAsistencias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Estilo del encabezado de columna
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.FromArgb(169, 169, 169); // Color de fondo del encabezado
            cabecera.ForeColor = Color.Black;                   // Color del texto en el encabezado
            cabecera.Font = new Font("Arial", 12, FontStyle.Regular); // Fuente del texto en el encabezado
            cabecera.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar texto en el encabezado
            dgv_RegistrosAsistencias.ColumnHeadersDefaultCellStyle = cabecera;

            // Estilo de las celdas
            DataGridViewCellStyle celdas = new DataGridViewCellStyle();
            celdas.BackColor = Color.White;                     // Fondo de las celdas
            celdas.ForeColor = Color.Black;                     // Color del texto en las celdas
            celdas.SelectionBackColor = Color.Gray;             // Fondo cuando una fila es seleccionada
            celdas.SelectionForeColor = Color.White;            // Color del texto cuando una fila es seleccionada
            celdas.Font = new Font("Arial", 11);                // Fuente para el texto en las celdas
            celdas.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar el contenido de las celdas
            dgv_RegistrosAsistencias.DefaultCellStyle = celdas;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatosAsistencias();
        }
    }
}
