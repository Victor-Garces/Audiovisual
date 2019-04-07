using System.Data.Entity;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.Forms.RentaDevoluciones
{
    public partial class DevolucionCrud : Form
    {
        private readonly RentaDevolucion _rentaDevolucion;

        public DevolucionCrud(RentaDevolucion rentaDevolucion)
        {
            _rentaDevolucion = rentaDevolucion;
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (var context = new DianaContext())
            {
                _rentaDevolucion.Comentario = txtComentario.Text;
                _rentaDevolucion.Estado = true;
                _rentaDevolucion.FechaDevolucion = dtFechaDevolucion.Value;
                context.Entry(_rentaDevolucion).State = EntityState.Modified;
                context.SaveChanges();
            }

            var rentaDevolucionesLista = new RentaDevolucionesLista();
            rentaDevolucionesLista.Show();
            Hide();

            string message = "Devolución exitosa";
            string title = "Exito";
            MessageBox.Show(message, title);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            var main = new Main();
            main.Show();
            Hide();


        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
