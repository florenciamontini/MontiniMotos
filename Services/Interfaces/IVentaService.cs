using MontiniMotos.Models;

namespace MontiniMotos.Services.Interfaces
{
    public interface IVentaService
    {
        Task<List<Venta>> GetVentas();
        Task<Venta> GetVenta(int id);
    }
}
