using Microsoft.EntityFrameworkCore;
using MontiniMotos.Models;
using MontiniMotos.Services.Interfaces;

namespace MontiniMotos.Services
{
    public class VentaService : IVentaService
    {
        private readonly VentasDbContext _context;
        public VentaService(VentasDbContext context)
        {
            _context = context;
        }
        //Get de todas las ventas
        public async Task<List<Venta>> GetVentas()
        {
            var resultado = await _context.Ventas.ToListAsync();

            return resultado;
        }

        //Get venta por id
        public async Task<Venta> GetVenta(int id)
        {

            return await _context.Ventas.FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
