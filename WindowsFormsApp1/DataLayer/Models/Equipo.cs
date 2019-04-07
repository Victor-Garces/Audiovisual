using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.DataLayer.Models
{
    [Table("Equipos")]
    public class Equipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int NoSerial { get; set; }
        public int TipoEquipo_Id { get; set; }
        public TipoEquipo TipoEquipo { get; set; }
        public int Marca_Id { get; set; }
        public Marca Marca { get; set; }
        public int Modelo_Id { get; set; }
        public Modelo Modelo { get; set; }
        public int TipoConexion_Id { get; set; }
        public TipoConexion TipoConexion { get; set; }
        public bool Estado { get; set; }
    }
}
