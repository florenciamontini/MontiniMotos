namespace MontiniMotos.Models
{
    public class Proveedor
    {
        public Proveedor()
        {
            
        }

        public Proveedor(string nombre, string mail)
        {
            Nombre = nombre;
            Mail = mail;
        }
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Mail { get; private set; }
    }
}
