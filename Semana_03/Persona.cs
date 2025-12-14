public class Persona
{
    // Definición de la clase Persona con sus respectivas propiedades.
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }

    // Creción del constructor.
    public Persona(string nombre, string apellido, string direccion)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Direccion = direccion;
    }
}