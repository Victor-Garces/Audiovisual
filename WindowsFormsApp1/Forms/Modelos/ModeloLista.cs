using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Modelos
{
    public partial class ModeloLista : Form
    {
        public ModeloLista()
        {
            InitializeComponent();
        }

        private void ModeloLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUDIOVISUALDataSet5.Modelos' table. You can move, or remove it, as needed.
            this.modelosTableAdapter.Fill(this.aUDIOVISUALDataSet5.Modelos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var modeloCrud = new ModeloCrud();
            modeloCrud.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }
    }
}
