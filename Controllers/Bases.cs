using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistencia.Controllers
{
    public class Bases
    {
        public static void DisenoDtv(ref DataGridView Listado) 
        {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.FromArgb(169, 169, 169);
            Listado.RowHeadersVisible = false;
            Listado.EnableHeadersVisualStyles = false;
            Listado.BorderStyle = BorderStyle.None;
            Listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.FromArgb(169, 169, 169);
            cabecera.ForeColor = Color.Black;
            cabecera.Font = new Font("Arial", 12);
            Listado.ColumnHeadersDefaultCellStyle = cabecera;
            



        }
      

    }
}
