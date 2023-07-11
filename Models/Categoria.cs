namespace MontiniMotos.Models
{
    public class Categoria
    {
        public Categoria()
        {
            
        }
        public Categoria(string descr_categoria) //Sobrecarga de constructor para poder setear los atributos de una instancia de categoria
        {
                Descr_categoria = descr_categoria;
        }
        public int Id { get; private set; }
        public string Descr_categoria { get; private set; }
    }
}
