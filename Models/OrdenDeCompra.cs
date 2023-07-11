namespace MontiniMotos.Models
{
    public class OrdenDeCompra

    {
        public OrdenDeCompra()
        {
                
        }
        public OrdenDeCompra(string descripcion, DateTime fecha, List<LineaOrdenDeCompra> linea_orden_compra)
        {
            Descripcion = descripcion;
            Fecha = fecha;
            Linea_orden_compra = linea_orden_compra;
        }
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
        public DateTime Fecha { get; private set; }
        public List<LineaOrdenDeCompra> Linea_orden_compra { get; private set; }
    }
}
