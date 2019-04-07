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
            if (Form1.usuario.IsAdmin != true)
            {
                string asd = "Usted no tiene permisos para crear usuarios";
                string zxc = "Error";
                MessageBox.Show(asd, zxc);
                return;
            }

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
