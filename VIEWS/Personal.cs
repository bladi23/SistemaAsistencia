using SistemaAsistencia.Controllers;
using SistemaAsistencia.Models;
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

namespace SistemaAsistencia.VIEWS
{
    public partial class Personal : UserControl
    {
        EmpleadosController _EmpleadosController = new EmpleadosController();
        EmpleadosModel _EmpleadosModel = new EmpleadosModel();
        int id = 0;

        public Personal()
        {
            InitializeComponent();
            CargarDepartamentos();
            CargarCargos();
            //CargarEstados();
        }

        private void CargarDepartamentos()
        {
            // Aquí deberías cargar los departamentos desde la base de datos
            // Ejemplo:
            var departamentos = new List<string> { "Departamento 1", "Departamento 2" };
            cmb_Departamento.DataSource = departamentos;
        }

        private void CargarCargos()
        {
            // Aquí deberías cargar los cargos desde la base de datos
            // Ejemplo:
            var cargos = new List<string> { "Cargo 1", "Cargo 2" };
            cmb_Cargo.DataSource = cargos;
        }

        //private void CargarEstados()
        //{
        //    // Aquí deberías cargar los estados desde la base de datos o definirlos manualmente
        //    // Ejemplo:
        //    var estados = new List<string> { "Activo", "Inactivo" };
        //    cmb_Estado.DataSource = estados;
        //}

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                var resultado = new EmpleadosModel();
                string res = "";
                var empleado = new EmpleadosModel
                {
                    empleados_id = this.id,
                    nombre = txt_Nombre.Text.Trim(),
                    apellido = txt_Apellido.Text.Trim(),
                    cedula = txt_Cedula.Text.Trim(),
                    departamento_id = Convert.ToInt32(cmb_Departamento.SelectedValue),
                    cargo_id = Convert.ToInt32(cmb_Cargo.SelectedValue),
                    fecha_contratacion = dtp_FechaContratacion.Value,
                    estado = cmb_Estado.SelectedItem.ToString(),
                    nombre_departamento = txt_Departamento.Text.Trim(), // Asignar el nombre del departamento
                    nombre_cargo = txt_Cargo.Text.Trim() // Asignar el nombre del cargo
                };

                if (this.id != 0)
                {
                    res = EmpleadosModel.Editar(empleado) ? "ok" : "error";
                }
                else
                {
                    resultado = _EmpleadosController.InsertarEmpleado(empleado);
                    res = resultado != null && resultado.empleados_id > 0 ? "ok" : "error";
                }

                if (res == "ok")
                {
                    MessageBox.Show("Se guardó con éxito");
                    cargalista();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar, inténtelo más tarde");
                }
            }
        }

        private void LimpiarFormulario()
        {
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_Cedula.Text = "";
            txt_Departamento.Text = "";
            txt_Cargo.Text = "";
            cmb_Departamento.SelectedIndex = 0;
            cmb_Cargo.SelectedIndex = 0;
            dtp_FechaContratacion.Value = DateTime.Now;
            cmb_Estado.SelectedIndex = 0;
        }

        public bool Comprobar()
        {
            if (txt_Nombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }
            else if (txt_Apellido.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el apellido");
                return false;
            }
            else if (txt_Cedula.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la Cédula");
                return false;
            }
            else if (cmb_Departamento.SelectedIndex == -1 || cmb_Departamento.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un departamento de la lista");
                return false;
            }
            else if (cmb_Cargo.SelectedIndex == -1 || cmb_Cargo.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un cargo de la lista");
                return false;
            }
            //else if (cmb_Estado.SelectedIndex == -1 || cmb_Estado.SelectedIndex == 0)
            //{
            //    MessageBox.Show("Seleccione un estado de la lista");
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }
    }
}
