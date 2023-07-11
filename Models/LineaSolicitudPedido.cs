namespace MontiniMotos.Models
{
    public class LineaSolicitudPedido
    {
        public LineaSolicitudPedido()
        {
            
        }
        public LineaSolicitudPedido(decimal precio_del_momento, int cantidad, Repuesto repuesto)
        {
            Precio_del_momento = precio_del_momento;
            Cantidad = cantidad;
            Repuesto = repuesto;
        }
        public int Id { get; private set; }
        public decimal Precio_del_momento { get; private set; }
        public int Cantidad { get; private set; }
        public Repuesto Repuesto { get; private set; }
    }
}
