namespace MontiniMotos.Models
{
    public class Cliente
    {
        public Cliente() //Constructor de la clase, inicializa el objeto vacio
        {
                
        }

        public Cliente(string apellido_cli, string dni_cli) //Sobrecarga de constructor para poder setear los atributos de una instancia de Cliente
        {
            Apellido_cli = apellido_cli;
            Dni_cli = dni_cli; 
        }
        public int Id { get; private set; }
        public string Apellido_cli { get; private set; }
        public string Dni_cli { get; private set; }

        
    }
   
}
