using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class EmpleadoCrud : Form
    {
        public EmpleadoCrud()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadoCrud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var empleado = new Empleado
            {
                Cedula = textBox6.Text,
                Estado = checkBox1.Checked,
                FechaIngreso = dateTimePicker1.Value,
                Nombre = textBox1.Text,
                Tanda = textBox4.Text
            };

            if (ValidacionCedula(empleado.Cedula))
            {
                if (Form1.usuario.IsAdmin != true)
                {
                    string asd = "Usted no tiene permisos para crear empleados";
                    string zxc = "Exito";
                    MessageBox.Show(asd, zxc);
                    return;
                }

                using (var context = new DianaContext())
                {
                    context.Empleados.Add(empleado);
                    context.SaveChanges();
                }

                var empleadoLista = new EmpleadoLista();
                empleadoLista.Show();
                Hide();

                string message = "Empleado creado";
                string title = "Exito";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "La cedula esta incorrecta";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }



        private bool ValidacionCedula(string pCedula)
        {
            if (pCedula == "00000000000")
            {
                return false;
            }

            int vnTotal = 0;

            string vcCedula = pCedula.Replace("-", "");

            int pLongCed = vcCedula.Trim().Length;

            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }
            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
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
    }
}
