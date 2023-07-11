using Microsoft.EntityFrameworkCore;
using MontiniMotos.Models;
using MontiniMotos.Services.Interfaces;

namespace MontiniMotos.Services
{
    public class SolicitudPedidosService : ISolicitudPedidoService
    {
        private readonly VentasDbContext _context;
        public SolicitudPedidosService(VentasDbContext context)
        {
            _context = context;
        }
        //Get de todos los solicitudes de pedido
        public async Task<List<SolicitudPedido>> GetPedidos()
        {
            var resultado = await _context.SolicitudPedidos.ToListAsync();

            return resultado;
        }

        //Get de todos los solicitudes de pedido
        public async Task<SolicitudPedido> GetPedido(int id)
        {

            return await _context.SolicitudPedidos.FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
