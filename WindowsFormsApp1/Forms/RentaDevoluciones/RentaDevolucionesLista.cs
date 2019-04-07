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
        private string ruta = @"D:\Victor\ReporterRD.csv";

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
            try
            {
                StreamWriter csvFileWriter = new StreamWriter(ruta, false);

                string columnHeaderText = "";

                int countColumn = dataGridView1.ColumnCount - 1;

                if (countColumn >= 0)
                {
                    columnHeaderText = dataGridView1.Columns[0].HeaderText;
                }

                for (int i = 1; i <= countColumn; i++)
                {
                    columnHeaderText = columnHeaderText + ',' + dataGridView1.Columns[i].HeaderText;
                }


                csvFileWriter.WriteLine(columnHeaderText);

                foreach (DataGridViewRow dataRowObject in dataGridView1.Rows)
                {
                    if (!dataRowObject.IsNewRow)
                    {
                        string dataFromGrid = "";

                        dataFromGrid = dataRowObject.Cells[0].Value.ToString();

                        for (int i = 1; i <= countColumn; i++)
                        {
                            dataFromGrid = dataFromGrid + ',' + dataRowObject.Cells[i].Value.ToString();

                            csvFileWriter.WriteLine(dataFromGrid);
                        }
                    }
                }

                csvFileWriter.Flush();
                csvFileWriter.Close();

                string message = "Exportación completada";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            catch (Exception exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }
        }
    }
}
