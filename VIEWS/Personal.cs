﻿

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
using System.Data.SqlClient;

namespace SistemaAsistencia.VIEWS
{
    public partial class Personal : UserControl
    {
      

        public Personal()
        {
            InitializeComponent();
            CargarDepartamentos();
           
          
        }
        int departamento_id=0;
        int cargo_id=0;
        int desde = 1;
        int hasta = 10;
        int contador;
        int empleado_id;
        private int items_por_pagina = 10;
        string estado;
        int totalPaginas;

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nombre.Text)) 
            {
                if (!string.IsNullOrEmpty(txt_apellido.Text)) 
                {
                    if(!string.IsNullOrEmpty(txt_cedula.Text))
                    {
                        if (departamento_id>0)
                        {
                            if (cargo_id>0)
                            {
                                InsertarPersonal();
                            }
                        }
                    }
                }
            }
        }
        private void mostrarPersonal()
        {
            DataTable dt = new DataTable(); 
            PersonalControlers personalControlers = new PersonalControlers();
            PersonalModels personalModels = new PersonalModels();
            personalModels.mostrarPersonal(ref dt, desde, hasta);
            // Asignar el DataTable al DataGridView
            dataGridView1.DataSource = dt;
            DisenoDtvPersonal();


        }

        private void DisenoDtvPersonal() 
        {
            
            Bases.DisenoDtv(ref dataGridView1);
  
            dataGridView1.Visible = true;
            PanelPaginado.Visible = true;

        }


        private void InsertarPersonal()
        {
            PersonalControlers personalControlers = new PersonalControlers();
            PersonalModels personalModel = new PersonalModels();
            personalControlers.nombre= txt_nombre.Text;
            personalControlers.apellido = txt_apellido.Text;
            personalControlers.cedula = txt_cedula.Text;
            personalControlers.departamento_id = departamento_id;
            personalControlers.cargo_id = cargo_id;
            personalControlers.fecha_contratacion = dtp_fechaContratacion.Value;
            if (personalModel.InsertarPersonal(personalControlers)== true)
            {
                mostrarPersonal();
                PanelRegistros.Visible= false;
            }
            
        }
        private void InsertarDepartamento()
        {
            if (!string.IsNullOrEmpty(txt_agg_departamento.Text))
            {
                DepartamentoController departamentoControlers = new DepartamentoController();
                DepartamentoModel departamentoModels = new DepartamentoModel();
                departamentoControlers.nombre_departamento = txt_agg_departamento.Text;
                if (departamentoModels.InsertarDepartamento(departamentoControlers))
                {
                    txt_departamento.Clear();
                    buscarDepartamentos();
                    PanelDepartamento.Visible = false;

                }

            }
            else { 
                MessageBox.Show("Agregar el Departamento");
            }
            
            
        }

        private void EditarDepartamento()
        {
            if (!string.IsNullOrEmpty(txt_agg_departamento.Text))
            {
                DepartamentoController departamentoControlers = new DepartamentoController();
                DepartamentoModel departamentoModels = new DepartamentoModel();

                
                departamentoControlers.departamento_id = departamento_id; 
                departamentoControlers.nombre_departamento = txt_agg_departamento.Text;

                if (departamentoModels.EditarDepartamento(departamentoControlers))
                {
                    txt_departamento.Clear();
                    buscarDepartamentos();
                    PanelDepartamento.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Agregar el Departamento");
            }
        }








        private void InsertarCargo()
        {
            if (!string.IsNullOrEmpty(txt_agg_cargo.Text) && comboBox1.SelectedValue != null)
            {
                CargoController cargoController = new CargoController();
                CargoModels cargoModel = new CargoModels();

                cargoController.nombre_cargo = txt_agg_cargo.Text;
                cargoController.departamento_id = Convert.ToInt32(comboBox1.SelectedValue);  // Obtener el ID del departamento

                if (cargoModel.InsertarCargo(cargoController))
                {
                    txt_agg_cargo.Clear();
                    buscarCargos();  // Refresca la lista de cargos
                    PanelCargo.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Agregar el Cargo y seleccionar un Departamento");
            }
        }





        private void EditarCargo()
        {
            if (!string.IsNullOrEmpty(txt_agg_cargo.Text))
            {
                CargoController cargoController = new CargoController();
                CargoModels cargoModel = new CargoModels();

                
                cargoController.cargo_id = cargo_id; 
                cargoController.nombre_cargo = txt_agg_cargo.Text;
               cargoController.departamento_id = Convert.ToInt32(comboBox1.SelectedValue);
              

                if (cargoModel.editarCargo(cargoController))
                {
                    txt_cargo.Clear();
                    buscarCargos();
                    PanelCargo.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Agregar el Cargo");
            }
        }



        private void buscarDepartamentos()
        {
            DataTable dt = new DataTable();
            DepartamentoModel departamentoModel = new DepartamentoModel();
            departamentoModel.buscarDepartamentos(ref dt, txt_departamento.Text);
            data_lista_departamentos.DataSource = dt;
            Bases.DisenoDtv(ref data_lista_departamentos);
            data_lista_departamentos.Visible = true;
            data_lista_departamentos.Columns[1].Visible = false;
        }
        
        private void buscarCargos()
        {
            
            DataTable dt = new DataTable();
            CargoModels cargoModel = new CargoModels();
            cargoModel.buscarCargos(ref dt, txt_cargo.Text); 
            data_lista_cargos.DataSource = dt;
            Bases.DisenoDtv(ref data_lista_cargos);
            data_lista_cargos.Visible = true;
            data_lista_cargos.Columns[1].Visible = false;
            data_lista_cargos.Columns[3].Visible = false;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron cargos para mostrar.");
            }
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //LocalizarDtvDepartamento();
            //LocalizarDtvCargo();
            PanelDepartamento.Visible = false;
            PanelCargo.Visible = false;
            PanelRegistros.Visible = true;
            PanelPaginado.Visible = false;
            PanelRegistros.Dock = DockStyle.Fill;
            Panel_btn_guardar_personal.Visible = true;  
            btn_guardar_personal.Visible = true;
            btn_guardar_cambios_personal.Visible = false;
            Limpiar();


        }
        private void LocalizarDtvDepartamento()
        {
            //data_lista_departamentos.Location = new Point(panel5.Location.X, panel5.Location.Y);
            data_lista_departamentos.Size = new Size(469, 130);
            data_lista_departamentos.Visible = true;
            Panel_btn_guardar_personal.Visible = false;
            
        }
        private void LocalizarDtvCargo()
        {
            //data_lista_cargos.Location = new Point(panel6.Location.X, panel6.Location.Y);
            data_lista_cargos.Size = new Size(532, 130);
            data_lista_cargos.Visible = true; 
            Panel_btn_guardar_personal.Visible = false;
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
       
            btn_aggDepartameno.Visible = true;
            btn_editarDepartamento.Visible = false;
            PanelDepartamento.Visible = true;
        }

        private void btn_guardarDepar_Click(object sender, EventArgs e)
        {
            InsertarDepartamento();
        }

        private void btn_agregarCargo_Click(object sender, EventArgs e)
        {
            CargarDepartamentos();  
            PanelCargo.Visible = true;
            btn_aggCargo.Visible = true;
            btn_editarCampo.Visible = false;
        }

        private void btn_guardarCargo_Click(object sender, EventArgs e)
        {
            InsertarCargo();
        }
        private void CargarDepartamentos()
        {
            try
            {
                using (var connection = Config.Conexion.GetConnection())
                {
                    using (var command = new SqlCommand("SELECT departamento_id, nombre_departamento FROM Departamentos", connection))
                    {
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            comboBox1.DataSource = dt;
                            comboBox1.DisplayMember = "nombre_departamento";  // Lo que se mostrará
                            comboBox1.ValueMember = "departamento_id";  // El valor real que será usado (departamento_id)
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al cargar los departamentos: {ex.Message}");
            }
        }

        private void lista_departamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDepartamentos();
        }

     

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            PanelRegistros.Visible = false;
        }

        private void txt_cargo_TextChanged(object sender, EventArgs e)
        {
            buscarCargos();
        }

        private void data_lista_departamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == data_lista_departamentos.Columns["EditarD"].Index)
            {
                ObtenerDepartamentosEditar();
            }
            if (e.ColumnIndex == data_lista_departamentos.Columns["nombre_departamento"].Index)
            {
                ObtenerDatosDepartamento();
            }
        }
        private void ObtenerDatosDepartamento()
        {
            departamento_id = Convert.ToInt32(data_lista_departamentos.SelectedCells[1].Value);
            txt_departamento.Text = data_lista_departamentos.SelectedCells[2].Value.ToString();
            data_lista_departamentos.Visible = false;
           
        }


        private void ObtenerDepartamentosEditar()
        {
            departamento_id= Convert.ToInt32(data_lista_departamentos.SelectedCells[1].Value);
            txt_agg_departamento.Text = data_lista_departamentos.SelectedCells[2].Value.ToString();
            btn_aggDepartameno.Visible = false;
            PanelDepartamento.Visible = true;
          

        }

        private void btn_volver_departamentos_Click(object sender, EventArgs e)
        {
            PanelDepartamento.Visible = false;
        }

        private void data_lista_cargos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == data_lista_cargos.Columns["EditarC"].Index)
            {
                ObtenerCargosEditar();
            }
            if (e.ColumnIndex == data_lista_cargos.Columns["nombre_cargo"].Index)
            {
                ObtenerDatosCargo();
            }

        }
        private void ObtenerDatosCargo()
        {
            cargo_id = Convert.ToInt32(data_lista_cargos.SelectedCells[1].Value);
            txt_cargo.Text = data_lista_cargos.SelectedCells[2].Value.ToString();
            data_lista_cargos.Visible = false;
          
          
        }

        private void ObtenerCargosEditar()
        {
            cargo_id = Convert.ToInt32(data_lista_cargos.SelectedCells[1].Value);
            txt_agg_cargo.Text = data_lista_cargos.SelectedCells[2].Value.ToString();
            btn_aggCargo.Visible = false;
            PanelCargo.Visible = true;
            btn_editarCampo.Visible = true;
          
         
        }

        private void btn_volver_Cargos_Click(object sender, EventArgs e)
        {
            PanelCargo.Visible = false;
        }

        private void btn_editarDepartamento_Click(object sender, EventArgs e)
        {
            EditarDepartamento();
        }

        private void btn_editarCampo_Click(object sender, EventArgs e)
        {
            EditarCargo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CargarDepartamentos();
        }

      

       

       

        private void Personal_Load(object sender, EventArgs e)
        {
            mostrarPersonal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            CerrarControl();
        }


        private void CerrarControl()
        {
            // Verificar si el UserControl tiene un contenedor
            if (this.Parent != null)
            {
                // Remover el UserControl del contenedor
                this.Parent.Controls.Remove(this);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                EliminarPersonal();
            }
            if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
            {
                obtenerDatos();
            }
        }




        private void obtenerDatos()
{
    empleado_id = Convert.ToInt32(dataGridView1.SelectedCells[2].Value);
    PersonalControlers personalControlers = new PersonalControlers();
    PersonalModels personalModels = new PersonalModels();
    
    // Obtener los datos del empleado
    personalControlers = personalModels.BuscarPersonalId(empleado_id);
    
    // Asignar los datos a los controles
    txt_nombre.Text = personalControlers.nombre;
    txt_apellido.Text = personalControlers.apellido;
    txt_cedula.Text = personalControlers.cedula;
    txt_departamento.Text =  personalControlers.nombre_departamento;
    txt_cargo.Text = personalControlers.nombre_cargo; 

  
    DateTime fechaContratacion = personalControlers.fecha_contratacion;
    if (fechaContratacion < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
        fechaContratacion > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
    {
        fechaContratacion = DateTime.Now; 
    }
    dtp_fechaContratacion.Value = fechaContratacion;

    // Mostrar el panel de edición
    PanelRegistros.Visible = true;
    PanelRegistros.Dock = DockStyle.Fill;
    Panel_btn_guardar_personal.Visible = true;
    btn_guardar_personal.Visible = false;
    btn_guardar_cambios_personal.Visible = true;
            PanelPaginado.Visible = false;

        }

      


        private void EliminarPersonal()
        {

            empleado_id = Convert.ToInt32(dataGridView1.SelectedCells[2].Value);
            PersonalControlers personalControlers = new PersonalControlers();
            PersonalModels personalModels = new PersonalModels();
            personalControlers.empleado_id = empleado_id;
            if (personalModels.eliminarPersonal(personalControlers)==true)
            {
                mostrarPersonal();
            }
        }

        private void txt_buscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonal();
        }


        private void BuscarPersonal()
        {
            PersonalModels personalModels = new PersonalModels();
            DataTable dt = new DataTable();
            personalModels.BuscarPersonal(ref dt, desde, hasta, txt_buscarEmpleado.Text);
            dataGridView1.DataSource = dt;
            DisenoDtvPersonal();
        }

        


    }
}
