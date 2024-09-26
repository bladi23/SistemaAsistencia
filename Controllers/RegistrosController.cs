using SistemaAsistencia.Controllers;
using SistemaAsistencia.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistencia.Controllers
{
    internal class RegistrosController
    {
        public DataTable CargarDatosAsistencias()
        {
            RegistrosModels registrosModels = new RegistrosModels();
            return registrosModels.CargarDatosAsistencias();
        }

    }

}

