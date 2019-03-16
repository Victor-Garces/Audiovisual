using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new DianaContext())
            {
                var user = context.Usuarios.FirstOrDefault(usuario =>
                    usuario.Username == textBox1.Text && usuario.Password == textBox2.Text);

                if (user != null)
                {
                    if (user.IsActive != true) 
                    {
                        string message = "Credenciales inválidas";
                        string title = "Error";
                        MessageBox.Show(message, title);
                        return;
                    }

                    usuario = user;
                    var main = new Main();
                    main.Show();
                    Hide();
                }
                else
                {
                    string message = "Las credenciales ingresadas no coinciden";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }
            }
        }

        public static Usuario usuario;
    }
}
