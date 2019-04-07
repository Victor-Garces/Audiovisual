using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Enums;
using WindowsFormsApp1.DataLayer.Models;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1.Forms.RentaDevoluciones
{
    public partial class RentaDevolucionesLista : Form
    {
        DataTable oDt = new DataTable();
        SqlConnection oCon = null;

        public RentaDevolucionesLista()
        {
         

            InitializeComponent();
            cmbTipo.DataSource = new[]
            {
                TipoAlquiler.Renta,
                TipoAlquiler.Devolucion
            };
        }

        private void RentaDevolucionesLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aUDIOVISUALDataSet71.RentaDevoluciones' table. You can move, or remove it, as needed.
            this.rentaDevolucionesTableAdapter1.Fill(this.aUDIOVISUALDataSet71.RentaDevoluciones);
            var bindingSource = new BindingSource
            {
                DataSource = dataGridView1.DataSource,
                Filter = "Estado = false"
            };
            dataGridView1.DataSource = bindingSource;
        }

     

        private void ejecutarConsulta(string pFiltro)
        {
            string sSQL = "  select * from RentaDevoluciones";
            if (pFiltro.Trim().Length > 0)
                sSQL += pFiltro;

            SqlDataAdapter oDa = new SqlDataAdapter(sSQL, oCon);
            oDt = new DataTable();
            oDa.Fill(oDt);
            dataGridView1.DataSource = oDt;
            dataGridView1.Refresh();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((TipoAlquiler) cmbTipo.SelectedValue == TipoAlquiler.Renta)
            {
                var bindingSource = new BindingSource
                {
                    DataSource = dataGridView1.DataSource,
                    Filter = "Estado = false"
                };
                dataGridView1.DataSource = bindingSource;
            }
            else
            {
                var bindingSource = new BindingSource
                {
                    DataSource = dataGridView1.DataSource,
                    Filter = "Estado = true"
                };
                dataGridView1.DataSource = bindingSource;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            var rentaCrud = new RentaCrud();
            rentaCrud.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
       

            var selected = dataGridView1.Rows[0].Cells[0].Value;

            if (selected != null)
            {
                int rentaId = (int)selected;

                using (var context = new DianaContext())
                {
                    RentaDevolucion rentaDevolucion = context.RentaDevoluciones.FirstOrDefault(devolucion => devolucion.Id == rentaId && devolucion.Estado == false);
                    if (rentaDevolucion != null)
                    {
                        var devolucionCrud = new DevolucionCrud(rentaDevolucion);
                        devolucionCrud.Show();
                        Hide();
                    }
                    else
                    {
                        string message = "Seleccione una renta válida";
                        string title = "Error";
                        MessageBox.Show(message, title);
                    }
                }
            }
            else
            {
                string message = "Seleccione una renta válida";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            writeFileHeader("sep=,");//Primera linea 
            writeFileLine("Prestamo_id, Empleado_id, Equipo_id, Usuario_id,FechaPrestamo,FechaDevolucion,Comentarios,Estado,Empleado_id1,Equipo_id1,Usuario_id1"); // segunda linea 

            foreach (DataRow row in oDt.Rows) //filas detalle 
            {
                string linea = "";
                foreach (DataColumn dc in oDt.Columns)
                {
                    linea += row[dc].ToString() + ",";
                }
                writeFileLine(linea);
            }

            Process.Start(@"C:\ReporteRentaDevolucion\ReporterRD.csv");
        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText("C:\\ReporteRentaDevolucion\\ReporterRD.csv"))
            {
                w.WriteLine(pLine);
            }
        }

        private void writeFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText("C:\\ReporteRentaDevolucion\\ReporterRD.csv"))
            {
                w.WriteLine(pLine);
            }
        }

    }
}
