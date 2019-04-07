using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.DataLayer.Models
{
    [Table("RentaDevoluciones")]
    public class RentaDevolucion
    {
        public int Id { get; set; }
        public int Empleado_Id { get; set; }
        public Empleado Empleado { get; set; }
        public int Equipo_Id { get; set; }
        public Equipo Equipo { get; set; }
        public int Usuario_Id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime? FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string Comentario { get; set; }
        public bool Estado { get; set; }
    }
}
