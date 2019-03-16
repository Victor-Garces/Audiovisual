using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Enums;

namespace WindowsFormsApp1.Forms.Usuario
{
    public partial class UsuarioCrud : Form
    {
        public UsuarioCrud()
        {
            InitializeComponent();
            cmbPersona.DataSource = new[]
            {
                TipoPersona.Fisica,
                TipoPersona.Juridica
            };
            cmbUsuario.DataSource = new[]
            {
                TipoUsuario.Empleado,
                TipoUsuario.Estudiante,
                TipoUsuario.Profesor
            };
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
                Username = txtNombre.Text,
                TipoUsuario = (TipoUsuario) cmbUsuario.SelectedValue,
                TipoPersona = (TipoPersona) cmbPersona.SelectedValue
            };

            if (ValidacionCedula(usuario.Cedula))
            {
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
            else
            {
                string body = "La cedula esta incorrecta";
                string header = "Error";
                MessageBox.Show(body, header);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }

        private bool ValidacionCedula(string pCedula)
        {
            if (pCedula == "00000000000")
            {
                return false;
            }

            int vnTotal = 0;

            string vcCedula = pCedula.Replace("-", "");

            int pLongCed = vcCedula.Trim().Length;

            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }
            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }
    }
}
