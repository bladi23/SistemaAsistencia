

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
        private void Insertar_Personal()
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
               BuscarDepartamento();
               
            }
            
        }
        private void BuscarDepartamento()
        {
            DataTable dt = new DataTable();
            DepartamentoModel departamentoModel = new DepartamentoModel();
            departamentoModel.buscarDepartamentos(ref dt, txt_departamento.Text);
            data_lista_cargos.DataSource = dt;
            Bases.DisenoDtv(ref data_lista_cargos);
            
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = false;
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
            BuscarDepartamento();
        }

        private void cmb_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_departamento_TextChanged(object sender, EventArgs e)
        {
            BuscarDepartamento();
        }

        private void data_lista_cargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

