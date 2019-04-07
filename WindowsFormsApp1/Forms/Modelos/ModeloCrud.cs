using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms.Modelos
{
    public partial class ModeloCrud : Form
    {
        public ModeloCrud()
        {
            InitializeComponent();
            using (var context = new DianaContext())
            {
                cmbMarca.DataSource = context.Marcas.Where(equipo => equipo.Estado).ToList();
                cmbMarca.DisplayMember = "descripcion";
                cmbMarca.ValueMember = "id";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.usuario.IsAdmin != true)
            {
                string asd = "Usted no tiene permisos para crear usuarios";
                string zxc = "Error";
                MessageBox.Show(asd, zxc);
                return;
            }

            var modelo = new Modelo
            {
                Descripcion = txtDescripcion.Text,
                Estado = chkStatus.Checked,
            };

            using (var context = new DianaContext())
            {
                modelo.Marca = context.Marcas.FirstOrDefault(marca => marca.Id == (int)cmbMarca.SelectedValue);
                context.Modelos.Add(modelo);
                context.SaveChanges();
            }

            var modeloLista = new ModeloLista();
            modeloLista.Show();
            Hide();

            string message = "Modelo creado";
            string title = "Exito";
            MessageBox.Show(message, title);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
