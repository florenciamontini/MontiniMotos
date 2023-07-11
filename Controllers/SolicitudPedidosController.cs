using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MontiniMotos.Models;
using MontiniMotos.Services.Interfaces;

namespace MontiniMotos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudPedidosController : ControllerBase
    {
        private readonly VentasDbContext _context;
        private readonly ISolicitudPedidoService _solicitudPedidoService;

        public SolicitudPedidosController(VentasDbContext context, ISolicitudPedidoService solicitudPedidoService)
        {
            _context = context;
            _solicitudPedidoService = solicitudPedidoService;
        }

        // GET: api/SolicitudPedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SolicitudPedido>>> GetSolicitudPedidos()
        {
            var resultado = _solicitudPedidoService.GetPedidos();
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }

        // GET: api/SolicitudPedidos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SolicitudPedido>> GetSolicitudPedido(int id)
        {
            var resultado = _solicitudPedidoService.GetPedido(id);
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }

        
    }
}
