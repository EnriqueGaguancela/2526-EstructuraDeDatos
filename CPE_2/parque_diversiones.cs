public class ParqueDiversiones
{
    
    private Queue<string> colaEspera = new Queue<string>();       // Cola para mantener el orden de llegada.

    
    private int capacidadMaxima = 30;       // Número máximo de personas permitidas (30).

    
    public void IngresarPersona(string nombre)       // Método para ingresar personas a la cola.
    {
        
        if (colaEspera.Count < capacidadMaxima)       // Verificar si aún hay espacio en la cola.
        {
            
            colaEspera.Enqueue(nombre);       // Agregar a la persona al final de la cola.
            Console.WriteLine($"[Ingreso] {nombre} ha ingresado a la cola.");
        }
        else
        {
            
            Console.WriteLine($"[Lleno] Ya no hay asientos disponibles para {nombre}.");       // Si la cola está llena, no permite el ingreso de más personas.
        }
    }

    
    public void ProcesarCola()       // Método para procesar a las personas que suben.
    {
        Console.WriteLine("\n[Inicio de abordaje a la atracción]");
        int asiento = 1;

        
        while (colaEspera.Count > 0)
        {
            
            string persona = colaEspera.Dequeue();

            
            Console.WriteLine($"Asiento #{asiento++}: {persona}");       // Asignación de número de asiento en orden de llegada.
        }
    }

   
    public void MostrarColaActual()        // Método para mostrar la cola actual.
    {
        Console.WriteLine("\n[Estado actual de la cola]");
        int posicion = 1;

        
        foreach (var persona in colaEspera)       // Se recorre cada persona en la cola para mostrar su posición.
        {
            Console.WriteLine($"{posicion++}. {persona}");
        }

        
        Console.WriteLine($"Total en cola: {colaEspera.Count}");
        Console.WriteLine($"Asientos disponibles: {capacidadMaxima - colaEspera.Count}");
    }
}
