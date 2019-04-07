using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer.Enums;

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
            // TODO: This line of code loads data into the 'aUDIOVISUALDataSet7.RentaDevoluciones' table. You can move, or remove it, as needed.
            this.rentaDevolucionesTableAdapter.Fill(this.aUDIOVISUALDataSet7.RentaDevoluciones);
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
    }
}
