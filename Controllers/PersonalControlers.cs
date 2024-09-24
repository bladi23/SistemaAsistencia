using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencia.Models
{
    public class PersonalControlers
    {
 //       [empleado_id][int] IDENTITY(1,1) NOT NULL,

 //   [nombre] [nvarchar] (50) NOT NULL,

 //   [apellido] [nvarchar] (50) NOT NULL,

 //   [cedula] [nvarchar] (10) NOT NULL,

 //   [departamento_id] [int] NULL,
	//[cargo_id][int] NULL,
	//[fecha_contratacion][date] NULL,
	//[estado][nvarchar] (10) NULL,
        
    public int empleado_id { get; set; }
    public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public int departamento_id { get; set; }
        public int cargo_id { get; set; }
        public DateTime fecha_contratacion { get; set; }
        public string estado { get; set; }
        

            
    }
}
