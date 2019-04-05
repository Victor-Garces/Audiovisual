using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Tipo_Equipo
{
    public partial class Tipoequipolista : Form
    {
        public Tipoequipolista()
        {
            InitializeComponent();
        }

        private void Tipoequipolista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUDIOVISUALDataSet4.TipoEquipos' table. You can move, or remove it, as needed.
            this.tipoEquiposTableAdapter.Fill(this.aUDIOVISUALDataSet4.TipoEquipos);

        }
    }
}
