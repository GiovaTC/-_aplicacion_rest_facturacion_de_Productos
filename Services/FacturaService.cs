// Services/FacturaService.cs

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
            _context.Facturas.Add(factura);

            await _context.SaveChangesAsync();
        }
    }
}