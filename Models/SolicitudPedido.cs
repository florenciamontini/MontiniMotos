namespace MontiniMotos.Models
{
    public class SolicitudPedido
    {
        public SolicitudPedido()
        {

        }

        public SolicitudPedido(int cant_repuesto_a_pedir, decimal montototal, Empleado empleado, OrdenDeCompra or_compra, Proveedor proveedor, DateTime fecha, List<LineaSolicitudPedido> linea_solic_pedido)
        {
            Cant_repuesto_a_pedir = cant_repuesto_a_pedir;
            Montototal = montototal;
            Empleado = empleado;
            Or_compra = or_compra;
            Proveedor = proveedor;
            Fecha = fecha;
            Linea_solic_pedido = linea_solic_pedido;

        }
        public int Id { get; private set; }
        public int Cant_repuesto_a_pedir { get; private set; }
        public decimal Montototal { get; private set; }
        public Empleado Empleado { get; private set; }
        public OrdenDeCompra Or_compra { get; private set; }
        public Proveedor Proveedor { get; private set; }
        public DateTime Fecha { get; private set; }
        public List<LineaSolicitudPedido> Linea_solic_pedido { get; private set; }
    }
}
