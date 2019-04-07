﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataLayer.Models
{
    [Table("Modelos")]
    public class Modelo
    {
        public int Id { get; set; }
        public Marca Marca { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
