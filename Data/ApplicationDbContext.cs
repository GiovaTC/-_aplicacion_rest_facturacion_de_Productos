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
        
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FacturaDetalle> FacturaDetalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factura>()
                .ToTable("FACTURAS");

            modelBuilder.Entity<FacturaDetalle>()
                .ToTable("FACTURA_DETALLE");
        }
    }   
}   
