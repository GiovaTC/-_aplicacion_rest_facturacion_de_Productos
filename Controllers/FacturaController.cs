using FacturacionAPI.Entities;
using FacturacionAPI.Services;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public async Task<IActionResult> RegistrarFactura(
            [FromBody] Factura factura)
        {
            await _service.GuardarFactura(factura);

            return Ok(new
            {
                mensaje = "Factura registrada correctamente"
            });
        }
    }   
}
