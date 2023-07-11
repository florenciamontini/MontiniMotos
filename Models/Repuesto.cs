namespace MontiniMotos.Models
{
    public class Repuesto
    {
        public Repuesto()
        {

        }
        public Repuesto(string nomb_repuesto, decimal precio, int cant_disponible, Categoria categoria)
        {
            Nom_repuesto = nomb_repuesto;
            Precio = precio;
            Cant_disponible = cant_disponible;
            Categoria = categoria;
        }
        public int Id { get; private set; }
        public string Nom_repuesto { get; private set; }
        public decimal Precio { get; private set; }
        public int Cant_disponible { get; private set; }
        public Categoria Categoria { get; private set; }
    }
}
