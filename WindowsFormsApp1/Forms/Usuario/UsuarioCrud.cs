using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;

namespace WindowsFormsApp1.Forms.Usuario
{
    public partial class UsuarioCrud : Form
    {
        public UsuarioCrud()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = new DataLayer.Models.Usuario
            {
                Cedula = txtCedula.Text,
                IsActive = chxActivo.Checked,
                IsAdmin = chxAdministrador.Checked,
                Password = txtContraseña.Text,
                Username = txtNombre.Text
            };

            if (Form1.usuario.IsAdmin != true)
            {
                string asd = "Usted no tiene permisos para crear usuarios";
                string zxc = "Error";
                MessageBox.Show(asd, zxc);
                return;
            }

            if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                string body = "Las contraseñas no coinciden";
                string header = "Error";
                MessageBox.Show(body, header);
                return;
            }

            using (var context = new DianaContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }

            var usuarioLista = new UsuarioLista();
            usuarioLista.Show();
            Hide();

            string message = "Usuario creado";
            string title = "Exito";
            MessageBox.Show(message, title);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }
    }
}
