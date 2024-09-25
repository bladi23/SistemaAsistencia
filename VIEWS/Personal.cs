

using SistemaAsistencia.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAsistencia.Controlles;
using SistemaAsistencia.Models;
using SistemaAsistencia.Controllers;

namespace SistemaAsistencia.VIEWS
{
    public partial class Personal : UserControl
    {
      

        public Personal()
        {
            InitializeComponent();
           
          
        }

        

     

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           
        }
        private void InsertarPersonal()
        {
            PersonalControlers personalControlers = new PersonalControlers();
            PersonalModels personalModel = new PersonalModels();
            personalControlers.nombre= txt_nombre.Text;
            personalControlers.apellido = txt_apellido.Text;
            personalControlers.cedula = txt_cedula.Text;
            
        }
        private void InsertarDepartamento()
        {

            DepartamentoController departamentoControlers = new DepartamentoController();
            DepartamentoModel departamentoModels = new DepartamentoModel();
            departamentoControlers.nombre_departamento = txt_agg_cargo.Text;
            if(departamentoModels.InsertarDepartamento(departamentoControlers))
            {
               buscarDepartamentos();
               
            }
            
        }
        private void InsertarCargo()
        {

            CargoController cargoControlers = new CargoController();
            CargoModels cargoModels = new CargoModels();
            cargoControlers.nombre_cargo = txt_agg_cargo.Text;
            if (cargoModels.InsertarCargo(cargoControlers))
            {
                buscarCargos();

            }

        }
        private void buscarDepartamentos()
        {
            DataTable dt = new DataTable();
            DepartamentoModel departamentoModel = new DepartamentoModel();
            departamentoModel.buscarDepartamentos(ref dt, txt_departamento.Text);
            data_lista_departamentos.DataSource = dt;
            Bases.DisenoDtv(ref data_lista_departamentos);
            
        }
        //private void buscarCargos()
        //{
        //    DataTable dt = new DataTable();
        //    CargoModels cargoModel = new CargoModels();
        //    cargoModel.buscarCargo(ref dt, txt_cargo.Text);
        //    data_lista_cargos.DataSource = dt;
        //    Bases.DisenoDtv(ref data_lista_cargos);

        //}
        private void buscarCargos()
        {
            // Crear un DataTable para almacenar los datos
            DataTable dt = new DataTable();

            // Crear una instancia del modelo de cargos
            CargoModels cargoModel = new CargoModels();

            // Llamar al método que busca los cargos
            cargoModel.buscarCargos(ref dt); // Asegúrate de que este método no requiera un parámetro para buscar

            // Asignar el DataTable como fuente de datos para el DataGridView
            data_lista_cargos.DataSource = dt;

            // Personalizar el diseño del DataGridView
            Bases.DisenoDtv(ref data_lista_cargos);

            // Opcional: Verificar si se encontraron datos
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron cargos para mostrar.");
            }
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            PanelDepartamento.Visible = false;
            PanelCargo.Visible = false;
            PanelRegistros.Visible = true;
            PanelPaginado.Visible = false;
            PanelRegistros.Dock = DockStyle.Fill;
            btn_guardar_personal.Visible = true;
            btn_guardar_cambios_personal.Visible = false;
            Limpiar();


        }
        private void Limpiar ()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_cedula.Clear();   
            buscarDepartamentos();
            buscarCargos();
        }

        private void cmb_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_departamento_TextChanged(object sender, EventArgs e)
        {
            buscarDepartamentos();
        }

        private void data_lista_cargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_agregaCargoDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregarDepartamento_Click(object sender, EventArgs e)
        {
            PanelDepartamento.Visible = true;  
            PanelDepartamento.Dock = DockStyle.Fill;    
            PanelDepartamento.BringToFront();
            btn_guardarDepar.Visible = true;
            btn_guardarCambiosDepart.Visible = false;
            txt_agg_departamento.Clear();
        }
    }
}

