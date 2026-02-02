class Program
{
    static void Main()
    {
        
        ParqueDiversiones parque = new ParqueDiversiones();       // Se crea una instancia de la clase que gestiona la cola.

        
        for (int i = 1; i <= 32; i++)       // Simulamos la llegada de 32 personas (2 serán rechazadas).
        {
           
            parque.IngresarPersona($"Persona_{i:000}");       // Se crea un nombre único para cada persona (Persona_001, Persona_002, ...)
        }

        
        parque.MostrarColaActual();       // Se muestra el estado actual de la cola.

       
        parque.ProcesarCola();        // Se procesan las personas para que suban.
    } 
}
