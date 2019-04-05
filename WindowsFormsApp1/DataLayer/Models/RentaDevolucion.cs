using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataLayer.Models
{
    public class RentaDevolucion
    {
        public int Id { get; set; }
        public int Empleado_Id { get; set; }
        public Empleado Empleado { get; set; }
        public int Equipo_Id { get; set; }
        public Equipo Equipo { get; set; }
        public int Usuario_Id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Comentario { get; set; }
        public bool Estado { get; set; }
    }
}
