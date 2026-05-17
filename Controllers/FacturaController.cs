// Controllers/FacturaController.cs

using FacturacionAPI.Entities;
using FacturacionAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FacturacionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturaController : ControllerBase
    {
        private readonly FacturaService _service;

        public FacturaController(FacturaService service)
        {
            _service = service;
        }

        // POST api/factura
        [HttpPost]
        public async Task<IActionResult> RegistrarFactura(
            [FromBody] Factura factura)
        {
            if (factura == null)
            {
                return BadRequest(new
                {
                    mensaje = "Factura vacía"
                });
            }

            if (factura.Detalles == null ||
                !factura.Detalles.Any())
            {
                return BadRequest(new
                {
                    mensaje = "Debe registrar detalles"
                });
            }

            decimal total = 0;

            foreach (var detalle in factura.Detalles)
            {
                detalle.Subtotal =
                    detalle.Cantidad * detalle.Precio;

                total += detalle.Subtotal;

                detalle.Factura = factura;
            }

            factura.Total = total;

            await _service.GuardarFactura(factura);

            return Ok(new
            {
                mensaje = "Factura registrada correctamente",
                factura.IdFactura,
                factura.Cliente,
                factura.FechaFactura,
                factura.Total
            });
        }

        // GET api/factura
        [HttpGet]
        public IActionResult Estado()
        {
            return Ok(new
            {
                mensaje = "API REST funcionando correctamente"
            });
        }
    }
}