using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Empleado
{
    public partial class EmpleadoLista : Form
    {
        public EmpleadoLista()
        {
            InitializeComponent();
        }

        private void EmpleadoLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUDIOVISUALDataSet.Empleados' table. You can move, or remove it, as needed.
            this.empleadosTableAdapter.Fill(this.aUDIOVISUALDataSet.Empleados);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var empleadoCrud = new EmpleadoCrud();
            empleadoCrud.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }
    }
}
