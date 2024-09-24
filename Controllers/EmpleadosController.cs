using SistemaAsistencia.Models;
using System.Collections.Generic;

namespace SistemaAsistencia.Controllers
{
    internal class EmpleadosController
    {
        public List<EmpleadosModel> BuscarEmpleados(int desde, int hasta, string buscador)
        {
            return EmpleadosModel.Buscar(desde, hasta, buscador);
        }

        public EmpleadosModel InsertarEmpleado(EmpleadosModel empleado)
        {
            return EmpleadosModel.Insertar(empleado);
        }

        public bool ActualizarEmpleado(EmpleadosModel empleado)
        {
            return EmpleadosModel.Editar(empleado);
        }

        public bool EliminarEmpleado(int empleadoId)
        {
            return EmpleadosModel.Eliminar(empleadoId);
        }
    }
}

