class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número de discos: ");
        int n;

        
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)       // Validación de entrada.
        {
            Console.Write("Por favor, ingrese un número entero positivo: ");
        }

        
        Hanoi juego = new Hanoi(n);       // Crear una instancia de la clase Hanoi.
    }
}
