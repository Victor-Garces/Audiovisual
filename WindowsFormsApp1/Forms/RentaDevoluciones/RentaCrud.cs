using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms.RentaDevoluciones
{
    public partial class RentaCrud : Form
    {
        public RentaCrud()
        {
            InitializeComponent();
            using (var context = new DianaContext())
            {
                cmbEmpleados.DataSource = context.TipoEquipos.Where(equipo => equipo.Estado).ToList();
                cmbEmpleados.DisplayMember = "nombre";
                cmbEmpleados.ValueMember = "id";

                cmbEquipos.DataSource = context.Marcas.Where(equipo => equipo.Estado).ToList();
                cmbEquipos.DisplayMember = "descripcion";
                cmbEquipos.ValueMember = "id";

                cmbUsuarios.DataSource = context.Modelos.Where(equipo => equipo.Estado).ToList();
                cmbUsuarios.DisplayMember = "descripcion";
                cmbUsuarios.ValueMember = "id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var renta = new RentaDevolucion
            {
                Empleado_Id = (int) cmbEmpleados.SelectedValue,
                Estado = false,
                Equipo_Id = (int) cmbEquipos.SelectedValue,
                Comentario = "",
                FechaPrestamo = dtFechaPrestamo.Value,
                Usuario_Id = (int) cmbUsuarios.SelectedValue
            };

            using (var context = new DianaContext())
            {
                context.RentaDevoluciones.Add(renta);
                context.SaveChanges();
            }

            var rentaDevolucionesLista = new RentaDevolucionesLista();
            rentaDevolucionesLista.Show();
            Hide();

            string message = "Renta creada";
            string title = "Exito";
            MessageBox.Show(message, title);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();
        }
    }
}
