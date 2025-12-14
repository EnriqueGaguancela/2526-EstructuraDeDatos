public class Estudiante : Persona
{
    public string [] num_tel { get; set; }
    public int ID { get; set; }

    public Estudiante(int ID, string nombre, string apellido, string direccion, string[] num_tel)
        : base(nombre, apellido, direccion)
    {
        this.ID = ID;
        this.num_tel = num_tel; // Asignar arreglo para los números de teléfono.
    }

    public void MostrarInformacionEstudiante()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombre del estudiante: {Nombre}");
        Console.WriteLine($"Apellido del estudiante: {Apellido}");
        Console.WriteLine($"Dirección Domiciliaria: {Direccion}");
        Console.WriteLine("Números de contacto:");
        int contador = 1;
        // Iterar el arreglo de números de teléfono y visualizarlos.
        foreach (var telefono in num_tel)
        {
            Console.WriteLine($" {contador++}- {telefono}");
        }
    }
}