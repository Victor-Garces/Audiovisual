using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms.Equipos
{
    public partial class EquipoCrud : Form
    {
        public EquipoCrud()
        {
            InitializeComponent();
            using (var context = new DianaContext())
            {
                cmbTipoConexion.DataSource = context.TipoEquipos.ToList();
                cmbMarca.DataSource = context.Marcas.ToList();
                cmbModelo.DataSource = context.Modelos.ToList();
                cmbTipoEquipo.DataSource = context.TipoEquipos.ToList();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var equipo = new Equipo
            {

            };
        }
    }
}
