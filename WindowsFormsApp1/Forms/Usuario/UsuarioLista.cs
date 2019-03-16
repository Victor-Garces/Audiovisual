using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Usuario
{
    public partial class UsuarioLista : Form
    {
        public UsuarioLista()
        {
            InitializeComponent();
        }

        private void UsuarioLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUDIOVISUALDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.aUDIOVISUALDataSet1.Usuarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuarioCrud = new UsuarioCrud();
            usuarioCrud.Show();
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
