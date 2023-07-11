namespace MontiniMotos.Models
{
    public class LineaVenta
    {
        public int Id { get; private set; }
        public decimal Precio_del_momento { get; private set; }
        public Repuesto Repuesto { get; private set; }
        public int Cantidad { get; private set; }
    }
}
