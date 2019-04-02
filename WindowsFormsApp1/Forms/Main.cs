using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms.Empleado;
using WindowsFormsApp1.Forms.Equipos;
using WindowsFormsApp1.Forms.Usuario;

namespace WindowsFormsApp1.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuarioLista = new UsuarioLista();
            usuarioLista.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var empleadoLista = new EmpleadoLista();
            empleadoLista.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var equiposLista = new EquiposLista();
            equiposLista.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var marcas = new Marcas.Marcas();
            marcas.Show();
            Hide();
        }
    }
}
