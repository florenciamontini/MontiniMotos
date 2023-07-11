namespace MontiniMotos.Models
{
    public class LineaOrdenDeCompra
    {
        public LineaOrdenDeCompra()
        {
            
        }

        public LineaOrdenDeCompra(decimal precio_del_momento, Repuesto repuesto, int cantidad)
        {
            Precio_del_momento = precio_del_momento;
            Repuesto = repuesto;
            Cantidad = cantidad;
        }
        public int Id { get; private set; }
        public decimal Precio_del_momento { get; private set; }
        public Repuesto Repuesto { get; private set; }
        public int Cantidad { get; private set; }
    }
}
