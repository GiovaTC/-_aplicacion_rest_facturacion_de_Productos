using FacturacionAPI.Data;
using FacturacionAPI.Entities;

namespace FacturacionAPI.Services
{
    public class FacturaService
    {
        private readonly ApplicationDbContext _context;

        public FacturaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task GuardarFactura(Factura factura)
        {
            decimal total = 0;

            foreach (var item in factura.Detalles)
            {
                item.Subtotal = item.Cantidad * item.Precio;
                total += item.Subtotal;

            }

            factura.Total = total;

            _context.Facturas.Add(factura);
            await _context.SaveChangesAsync();
        }
    }
}   
