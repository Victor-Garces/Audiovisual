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
