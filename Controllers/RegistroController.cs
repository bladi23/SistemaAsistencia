using SistemaAsistencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencia.Controllers
{
    internal class RegistroController
    {
        public string ObtenerNombreYApellidoPorId(int idHuella)
        {
            return RegistroModel.ObtenerNombreYApellidoPorId(idHuella);
        }
    }
}

