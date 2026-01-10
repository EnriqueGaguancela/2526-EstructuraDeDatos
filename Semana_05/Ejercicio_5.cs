using System;
using System.Collections.Generic;

class Ejercicio_5
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ejercicio #5");

        Console.Write("Introducir una palabra: ");
        string? input = Console.ReadLine();
        string palabra = (input ?? "").ToLower(); // Evita null

        // Invertir la palabra
        char[] caracteres = palabra.ToCharArray();
        Array.Reverse(caracteres);
        string palabraInvertida = new string(caracteres);

        // Verificar si es un palíndromo.
        if (palabra == palabraInvertida)
        {
            Console.WriteLine("La palabra es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra no es un palíndromo.");
        }
    }
}
