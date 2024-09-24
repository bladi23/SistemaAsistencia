

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
               txt_agg_cargo.Clear();
               
            }
            
        }
        private void BuscarDepartamento()
        {
            // Crear instancia del modelo
            DepartamentoModel departamentoModel = new DepartamentoModel();

            // Obtener el texto del TextBox para usarlo como criterio de búsqueda
            string buscador = txt_departamento.Text;

            // Llamar al método BuscarDepartamento y pasar el DataGridView junto con el criterio de búsqueda
            departamentoModel.BuscarDepartamento(data_lista_cargos, buscador);
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
        }

        private void cmb_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

