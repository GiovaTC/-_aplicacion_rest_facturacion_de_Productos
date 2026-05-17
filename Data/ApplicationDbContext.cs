// Data/ApplicationDbContext.cs

using FacturacionAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FacturacionAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Factura> Facturas => Set<Factura>();
        public DbSet<FacturaDetalle> FacturaDetalles => Set<FacturaDetalle>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factura>()
                .HasMany(f => f.Detalles)
                .WithOne(d => d.Factura)
                .HasForeignKey(d => d.IdFactura);

            base.OnModelCreating(modelBuilder);
        }
    }
}