using System;

namespace WindowsFormsApp1.DataLayer.Models
{
    public sealed class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Tanda { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
    }
}
