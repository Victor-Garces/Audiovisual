using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms.Equipos
{
    public partial class EquipoCrud : Form
    {
        public EquipoCrud()
        {
            InitializeComponent();
            using (var context = new DianaContext())
            {
                cmbTipoConexion.DataSource = context.TipoEquipos.Where(equipo => equipo.Estado).ToList();
                cmbTipoConexion.DisplayMember = "descripcion";
                cmbTipoConexion.ValueMember = "id";

                cmbMarca.DataSource = context.Marcas.Where(equipo => equipo.Estado).ToList();
                cmbMarca.DisplayMember = "descripcion";
                cmbMarca.ValueMember = "id";

                cmbModelo.DataSource = context.Modelos.Where(equipo => equipo.Estado).ToList();
                cmbModelo.DisplayMember = "descripcion";
                cmbModelo.ValueMember = "id";

                cmbTipoEquipo.DataSource = context.TipoEquipos.Where(equipo => equipo.Estado).ToList();
                cmbTipoEquipo.DisplayMember = "descripcion";
                cmbTipoEquipo.ValueMember = "id";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
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

            var equipo = new Equipo
            {
                TipoConexion_Id = (int) cmbTipoConexion.SelectedValue,
                TipoEquipo_Id = (int) cmbTipoEquipo.SelectedValue,
                Modelo_Id = (int) cmbModelo.SelectedValue,
                Marca_Id = (int) cmbMarca.SelectedValue,
                Descripcion = txtDescripcion.Text,
                NoSerial = Convert.ToInt32(txtNoSerial.Text),
                Estado = chkStatus.Checked,
            };


            using (var context = new DianaContext())
            {
                context.Equipos.Add(equipo);
                context.SaveChanges();
            }

            var equiposLista = new EquiposLista();
            equiposLista.Show();
            Hide();
            
            string message = "Equipo creado";
            string title = "Exito";
            MessageBox.Show(message, title);
        }

        private void txtNoSerial_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNoSerial.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor solo introduzca números.");
                txtNoSerial.Text = txtNoSerial.Text.Remove(txtNoSerial.Text.Length - 1);
            }
        }

        private void cmbTipoConexion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
