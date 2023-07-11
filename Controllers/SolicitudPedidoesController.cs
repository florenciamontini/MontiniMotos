using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MontiniMotos.Models;

namespace MontiniMotos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudPedidoesController : ControllerBase
    {
        private readonly VentasDbContext _context;

        public SolicitudPedidoesController(VentasDbContext context)
        {
            _context = context;
        }

        // GET: api/SolicitudPedidoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SolicitudPedido>>> GetSolicitudPedidos()
        {
          if (_context.SolicitudPedidos == null)
          {
              return NotFound();
          }
            return await _context.SolicitudPedidos.ToListAsync();
        }

        // GET: api/SolicitudPedidoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SolicitudPedido>> GetSolicitudPedido(int id)
        {
          if (_context.SolicitudPedidos == null)
          {
              return NotFound();
          }
            var solicitudPedido = await _context.SolicitudPedidos.FindAsync(id);

            if (solicitudPedido == null)
            {
                return NotFound();
            }

            return solicitudPedido;
        }

        // PUT: api/SolicitudPedidoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSolicitudPedido(int id, SolicitudPedido solicitudPedido)
        {
            if (id != solicitudPedido.Id)
            {
                return BadRequest();
            }

            _context.Entry(solicitudPedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SolicitudPedidoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SolicitudPedidoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SolicitudPedido>> PostSolicitudPedido(SolicitudPedido solicitudPedido)
        {
          if (_context.SolicitudPedidos == null)
          {
              return Problem("Entity set 'VentasDbContext.SolicitudPedidos'  is null.");
          }
            _context.SolicitudPedidos.Add(solicitudPedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSolicitudPedido", new { id = solicitudPedido.Id }, solicitudPedido);
        }

        // DELETE: api/SolicitudPedidoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSolicitudPedido(int id)
        {
            if (_context.SolicitudPedidos == null)
            {
                return NotFound();
            }
            var solicitudPedido = await _context.SolicitudPedidos.FindAsync(id);
            if (solicitudPedido == null)
            {
                return NotFound();
            }

            _context.SolicitudPedidos.Remove(solicitudPedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SolicitudPedidoExists(int id)
        {
            return (_context.SolicitudPedidos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
