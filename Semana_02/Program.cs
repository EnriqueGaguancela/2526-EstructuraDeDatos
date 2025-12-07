using System;          
using Figuras;         // Importa el namespace 'Figuras' donde se encuentran nuestras clases Rectangulo y Cuadrado.

// Clase principal del programa.
class Program
{
    // Método que se ejecuta al iniciar el programa.
    static void Main(string[] args)
    {
        
        Console.WriteLine("SEMANA N°2\n");  // "\n" agrega un salto de línea.

        // Creación del objeto Rectangulo: base 5 y altura 7.
        Rectangulo rectangulo = new Rectangulo(5, 7);

        // Creación del objeto Cuadrado con lado 10.
        Cuadrado cuadrado = new Cuadrado(10);

        // Encabezado de la tabla Rectángulo
        Console.WriteLine("Rectángulo       | Valor");
        Console.WriteLine("*****************|***********");

        // Mostrar la base del rectángulo.
        Console.WriteLine("Base             | " + rectangulo.Base);

        // Mostrar la altura del rectángulo.
        Console.WriteLine("Altura           | " + rectangulo.Altura);

        // Mostrar el área del rectángulo usando el método CalcularArea()
        Console.WriteLine("Área             | " + rectangulo.CalcularArea());

        // Mostrar el perímetro del rectángulo usando el método CalcularPerimetro()
        Console.WriteLine("Perímetro        | " + rectangulo.CalcularPerimetro());
        Console.WriteLine(); // Salto de línea para separar tablas

        // Encabezado de la tabla Cuadrado.
        Console.WriteLine("Cuadrado         | Valor");
        Console.WriteLine("*****************|***********");

        // Mostrar el lado del cuadrado.
        Console.WriteLine("Lado             | " + cuadrado.Lado);

        // Mostrar el área del cuadrado usando el método CalcularArea()
        Console.WriteLine("Área             | " + cuadrado.CalcularArea());

        // Mostrar el perímetro del cuadrado usando el método CalcularPerimetro()
        Console.WriteLine("Perímetro        | " + cuadrado.CalcularPerimetro());
        Console.WriteLine(); // Salto de línea final
    }
}
