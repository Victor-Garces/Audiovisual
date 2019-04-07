using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Marcas
{
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUDIOVISUALDataSet3.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.aUDIOVISUALDataSet3.Marcas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var marcaCrud = new MarcaCrud();
            marcaCrud.Show();
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
    }
}
