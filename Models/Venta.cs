namespace MontiniMotos.Models
{
    public class Venta
    {
        public Venta()
        {
            
        }
        public Venta(decimal total_venta, Empleado empleado, Cliente cliente, DateTime fecha, List<LineaVenta> linea_venta)
        {
            Total_venta = total_venta;
            Empleado = empleado;
            Cliente = cliente;
            Fecha = fecha;
            Linea_venta = linea_venta;
        }
        public int Id { get; private set; }
        public decimal Total_venta { get; private set; }
        public Empleado Empleado { get; private set; }
        public Cliente Cliente { get; private set; }
        public DateTime Fecha { get; private set; }
        public List<LineaVenta> Linea_venta { get; private set; }
    }
}
