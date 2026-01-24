class Program
{
    static void Main()
    {
        
        Ejercicio verificador = new Ejercicio();       // Crear una instancia de la clase Ejercicio.

        
        Console.Write("Ingrese la expresión matemática: ");       // Solicitar al usuario que ingrese una expresión matemática.
        string expresion = Console.ReadLine();

        
        if (verificador.EsBalanceada(expresion))       // Llama al método para verificar si la expresión está balanceada.
        {
            Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            Console.WriteLine("Fórmula NO balanceada.");
        }
    }
}
