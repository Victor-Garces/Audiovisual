using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms.Marcas
{
    public partial class MarcaCrud : Form
    {
        public MarcaCrud()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.usuario.IsAdmin != true)
            {
                string asd = "Usted no tiene permisos para crear usuarios";
                string zxc = "Error";
                MessageBox.Show(asd, zxc);
                return;
            }

            var marca = new Marca
            {
                Estado = chkStatus.Checked,
                Descripcion = txtDescripcion.Text
            };

            using (var context = new DianaContext())
            {
                context.Marcas.Add(marca);
                context.SaveChanges();
            }

            var marcas = new Marcas();
            marcas.Show();
            Hide();

            string message = "Marca creada";
            string title = "Exito";
            MessageBox.Show(message, title);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
