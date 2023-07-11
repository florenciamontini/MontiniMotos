using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MontiniMotos.Models;
using MontiniMotos.Services;
using MontiniMotos.Services.Interfaces;

namespace MontiniMotos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly VentasDbContext _context;
        private readonly IVentaService _ventaService;

        public VentasController(VentasDbContext context, IVentaService ventaService)
        {
            _context = context;
            _ventaService = ventaService;
        }
        // GET: api/Ventas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVentas()
        {
            var resultado = _ventaService.GetVentas();
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }

        // GET: api/Ventas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Venta>> GetVenta(int id)
        {
            var resultado = _ventaService.GetVenta(id);
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }
    }
}
