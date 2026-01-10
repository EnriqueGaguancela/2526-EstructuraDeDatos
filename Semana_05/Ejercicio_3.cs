using System;
using System.Collections.Generic;

class Ejercicio_3
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ejercicio #3");

        List<int> numeros = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        numeros.Reverse();

        Console.WriteLine("\nNúmeros del 1 al 10 en orden inverso:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}
