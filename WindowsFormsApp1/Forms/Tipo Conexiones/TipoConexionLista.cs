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
    }
}
