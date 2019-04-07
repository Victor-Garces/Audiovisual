using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms.Tipo_Equipo
{
    public partial class TipoEquipoCrud : Form
    {
        public TipoEquipoCrud()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.usuario.IsAdmin != true)
            {
                string asd = "Usted no tiene permisos para crear usuarios";
                string zxc = "Error";
                MessageBox.Show(asd, zxc);
                return;
            }

            var tipoEquipo = new TipoEquipo
            {
                Descripcion = txtDescripcion.Text,
                Estado = chkStatus.Checked
            };

            using (var context = new DianaContext())
            {
                context.TipoEquipos.Add(tipoEquipo);
                context.SaveChanges();
            }

            var tipoequipolista = new Tipoequipolista();
            tipoequipolista.Show();
            Hide();

            string message = "Tipo de equipo creado";
            string title = "Exito";
            MessageBox.Show(message, title);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }
    }
}
