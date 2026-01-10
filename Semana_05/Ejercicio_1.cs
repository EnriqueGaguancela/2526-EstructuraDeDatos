using System;
using System.Collections.Generic;

// Escribir un programa que almacene las asignaturas de un curso
// (por ejemplo Matemáticas, Física, Química, Historia y Lengua)
// en una lista y la muestre por pantalla de forma ordenada.

class Ejercicio_1
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ejercicio #1");

        int cantidad;
        while (true)
        {
            Console.Write("Ingrese el número de asignaturas: ");
            string? input = Console.ReadLine();

            // Validar que el usuario ingrese un número válido
            if (int.TryParse(input, out cantidad) && cantidad > 0)
            {
                break;
            }
            Console.WriteLine("Entrada inválida. Debe ingresar un número entero positivo.");
        }

        List<string> asignaturas = new List<string>();

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Asignatura {i + 1}: ");
            string? asignatura = Console.ReadLine();
            asignaturas.Add(asignatura ?? ""); // Evita null
        }

        asignaturas.Sort();

        Console.WriteLine("\nAsignaturas del estudiante:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}
