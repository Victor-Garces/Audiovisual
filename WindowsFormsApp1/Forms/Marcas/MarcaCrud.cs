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
    }
}
