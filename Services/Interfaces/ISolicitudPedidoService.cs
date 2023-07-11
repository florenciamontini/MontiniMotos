using MontiniMotos.Models;

namespace MontiniMotos.Services.Interfaces
{
    public interface ISolicitudPedidoService
    {
        Task<List<SolicitudPedido>> GetPedidos();
        Task<SolicitudPedido> GetPedido(int id);
    }
}
