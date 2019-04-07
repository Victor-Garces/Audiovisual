using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms.Empleado;
using WindowsFormsApp1.Forms.Equipos;
using WindowsFormsApp1.Forms.Modelos;
using WindowsFormsApp1.Forms.RentaDevoluciones;
using WindowsFormsApp1.Forms.Tipo_Conexiones;
using WindowsFormsApp1.Forms.Tipo_Equipo;
using WindowsFormsApp1.Forms.Usuario;

namespace WindowsFormsApp1.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuarioLista = new UsuarioLista();
            usuarioLista.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var empleadoLista = new EmpleadoLista();
            empleadoLista.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var equiposLista = new EquiposLista();
            equiposLista.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var marcas = new Marcas.Marcas();
            marcas.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var tipoequipolista = new Tipoequipolista();
            tipoequipolista.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var modeloLista = new ModeloLista();
            modeloLista.Show();
            Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var TipoConexionLista = new TipoConexionLista();
            TipoConexionLista.Show();
            Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var rentaDevolucionesLista = new RentaDevolucionesLista();
            rentaDevolucionesLista.Show();
            Hide();
        }
    }
}
