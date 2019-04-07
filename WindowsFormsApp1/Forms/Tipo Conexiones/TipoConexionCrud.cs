using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms.Tipo_Conexiones
{
    public partial class TipoConexionCrud : Form
    {
        public TipoConexionCrud()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var tipoConexion = new TipoConexion
            {
                Descripcion = txtDescripcion.Text,
                Estado = chkStatus.Checked
            };

            using (var context = new DianaContext())
            {
                context.TipoConexiones.Add(tipoConexion);
                context.SaveChanges();
            }

            var tipoConexionLista = new TipoConexionLista();
            tipoConexionLista.Show();
            Hide();

            string message = "Tipo de conexión creado";
            string title = "Exito";
            MessageBox.Show(message, title);
        }
    }
}
