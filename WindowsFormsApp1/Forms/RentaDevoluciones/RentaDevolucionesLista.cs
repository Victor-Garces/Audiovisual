using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Enums;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms.RentaDevoluciones
{
    public partial class RentaDevolucionesLista : Form
    {
        public RentaDevolucionesLista()
        {
            InitializeComponent();
            cmbTipo.DataSource = new[]
            {
                TipoAlquiler.Renta,
                TipoAlquiler.Devolucion
            };
        }

        private void RentaDevolucionesLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUDIOVISUALDataSet71.RentaDevoluciones' table. You can move, or remove it, as needed.
            this.rentaDevolucionesTableAdapter1.Fill(this.aUDIOVISUALDataSet71.RentaDevoluciones);
            var bindingSource = new BindingSource
            {
                DataSource = dataGridView1.DataSource,
                Filter = "Estado = false"
            };
            dataGridView1.DataSource = bindingSource;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((TipoAlquiler) cmbTipo.SelectedValue == TipoAlquiler.Renta)
            {
                var bindingSource = new BindingSource
                {
                    DataSource = dataGridView1.DataSource,
                    Filter = "Estado = false"
                };
                dataGridView1.DataSource = bindingSource;
            }
            else
            {
                var bindingSource = new BindingSource
                {
                    DataSource = dataGridView1.DataSource,
                    Filter = "Estado = true"
                };
                dataGridView1.DataSource = bindingSource;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rentaCrud = new RentaCrud();
            rentaCrud.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.Rows[0].Cells[0].Value;

            if (selected != null)
            {
                int rentaId = (int)selected;

                using (var context = new DianaContext())
                {
                    RentaDevolucion rentaDevolucion = context.RentaDevoluciones.FirstOrDefault(devolucion => devolucion.Id == rentaId && devolucion.Estado == false);
                    if (rentaDevolucion != null)
                    {
                        var devolucionCrud = new DevolucionCrud(rentaDevolucion);
                        devolucionCrud.Show();
                        Hide();
                    }
                    else
                    {
                        string message = "Seleccione una renta válida";
                        string title = "Error";
                        MessageBox.Show(message, title);
                    }
                }
            }
            else
            {
                string message = "Seleccione una renta válida";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }
    }
}
