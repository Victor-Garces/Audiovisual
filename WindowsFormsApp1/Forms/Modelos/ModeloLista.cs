using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
