namespace MontiniMotos.Models
{
    public class Empleado
    {
        public Empleado()
        {

        }

        public Empleado(string nombre_emp, string apellido_emp, string dni_emp)
        {
            Nombre_emp = nombre_emp;
            Apellido_emp = apellido_emp;
            Dni_emp = dni_emp;
        }
        public int Id { get; private set; }
        public string Nombre_emp { get; private set; }
        public string Apellido_emp { get; private set; }
        public string Dni_emp { get; private set; }
    }
}
