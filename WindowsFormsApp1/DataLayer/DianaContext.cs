using System.Data.Entity;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.DataLayer
{
    public class DianaContext : DbContext
    {
        public DianaContext() : base("AudioVisualConfiguration") { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<TipoEquipo> TipoEquipos { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<TipoConexion> TipoConexiones { get; set; }
        //public DbSet<RentaDevolucion> RentaDevoluciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ApplyConfigurations(modelBuilder);
        }

        private static void ApplyConfigurations(DbModelBuilder modelBuilder)
        {
        }
    }
}
