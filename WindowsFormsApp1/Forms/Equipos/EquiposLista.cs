using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Equipos
{
    public partial class EquiposLista : Form
    {
        public EquiposLista()
        {
            InitializeComponent();
        }

        private void EquiposLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUDIOVISUALDataSet2.Equipos' table. You can move, or remove it, as needed.
            this.equiposTableAdapter.Fill(this.aUDIOVISUALDataSet2.Equipos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var equipoCrud = new EquipoCrud();
            equipoCrud.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var bindingSource = new BindingSource
            {
                DataSource = dataGridView1.DataSource,
                Filter = "Descripcion" + " like '%" + textBox1.Text + "%'"
            };
            dataGridView1.DataSource = bindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
