using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Tipo_Conexiones
{
    public partial class TipoConexionLista : Form
    {
        public TipoConexionLista()
        {
            InitializeComponent();
        }

        private void TipoConexionLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUDIOVISUALDataSet6.TipoConexiones' table. You can move, or remove it, as needed.
            this.tipoConexionesTableAdapter.Fill(this.aUDIOVISUALDataSet6.TipoConexiones);

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

            var tipoConexionCrud = new TipoConexionCrud();
            tipoConexionCrud.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
