using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataLayer.Enums;

namespace WindowsFormsApp1.DataLayer.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int NoSerial { get; set; }
        public TipoEquipo TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public TipoTecnologiaConexion TipoTecnologiaConexion { get; set; }
        public bool Estado { get; set; }
    }
}
