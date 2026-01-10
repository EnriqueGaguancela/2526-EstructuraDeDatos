using System;
using System.Collections.Generic;

class Ejercicio_4
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ejercicio #4");

        Console.Write("Introduzca una palabra: ");
        string? input = Console.ReadLine();
        string palabra = (input ?? "").ToLower();

        int contadorA = 0;
        int contadorE = 0;
        int contadorI = 0;
        int contadorO = 0;
        int contadorU = 0;

        foreach (char letra in palabra)
        {
            switch (letra)
            {
                case 'a': contadorA++; break;
                case 'e': contadorE++; break;
                case 'i': contadorI++; break;
                case 'o': contadorO++; break;
                case 'u': contadorU++; break;
            }
        }

        Console.WriteLine("\nCantidad de vocales:");
        Console.WriteLine("a: " + contadorA);
        Console.WriteLine("e: " + contadorE);
        Console.WriteLine("i: " + contadorI);
        Console.WriteLine("o: " + contadorO);
        Console.WriteLine("u: " + contadorU);
    }
}
