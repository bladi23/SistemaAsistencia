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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = false;
            PanelRegistros.Visible = true;
            PanelPaginado.Visible = false;
            PanelRegistros.Dock = DockStyle.Fill;
            btn_guardar_personal.Visible = true;
            btn_guardar_cambios_personal.Visible = false;
            
        }
        private void Limpiar ()
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Cedula.Clear();
            cmb_Cargo.SelectedIndex = -1;
            cmb_Departamento.SelectedIndex = -1;
            dt_fecha_contratacion.Value = DateTime.Now;
            cb_estado.SelectedIndex = -1;
        }
    }
}

