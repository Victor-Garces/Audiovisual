using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Enums;
using WindowsFormsApp1.Forms.Empleado;

namespace WindowsFormsApp1.Forms
{
    public partial class EmpleadoCrud : Form
    {
        public EmpleadoCrud()
        {
            InitializeComponent();
            comboBox1.DataSource = new[]
            {
                Tanda.Matutina,
                Tanda.Vespertina,
                Tanda.Nocturna
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadoCrud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var empleado = new DataLayer.Models.Empleado
            {
                Cedula = textBox6.Text,
                Estado = checkBox1.Checked,
                FechaIngreso = dateTimePicker1.Value,
                Nombre = textBox1.Text,
                Tanda = (Tanda) comboBox1.SelectedValue
            };

            if (ValidacionCedula(empleado.Cedula))
            {
                if (Form1.usuario.IsAdmin != true)
                {
                    string body = "Usted no tiene permisos para crear empleados";
                    string header = "Exito";
                    MessageBox.Show(body, header);
                    return;
                }

                CrearNuevoEmpleado("Password=sa1234;Persist Security Info=True;User ID=sa;Initial Catalog=AUDIOVISUAL;Data Source=.", 
                    empleado.Nombre, empleado.Cedula, Convert.ToInt32(empleado.Tanda), empleado.FechaIngreso, empleado.Estado);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }

        private void CrearNuevoEmpleado(string connectionString, string nombre, string cedula, int tanda, DateTime fechaIngreso, bool estado)
        {
            string query = "INSERT INTO dbo.Empleados (Nombre, Cedula, Tanda, FechaIngreso, Estado) " +
                           "VALUES (@Nombre, @Cedula, @Tanda, @FechaIngreso, @Estado) ";

            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@Cedula", SqlDbType.VarChar, 50).Value = cedula;
                cmd.Parameters.Add("@Tanda", SqlDbType.Int).Value = tanda;
                cmd.Parameters.Add("@FechaIngreso", SqlDbType.DateTime).Value = fechaIngreso;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = estado;

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
