using SistemaAsistencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencia.Controllers
{
    internal class EmpleadosController
    {
        public string ObtenerNombreYApellidoPorId(int idHuella)
        {
            return EmpleadosModel.ObtenerNombreYApellidoPorId(idHuella);
        }
    }
}

