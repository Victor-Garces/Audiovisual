using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms.Empleado;
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
    }
}
