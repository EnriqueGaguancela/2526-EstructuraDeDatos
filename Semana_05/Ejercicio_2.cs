using System;
using System.Collections.Generic;

class Ejercicio_2
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ejercicio #2");

        List<string> asignaturas = new List<string>
        {
            "Metodología de la Investigación",
            "Administración de Sistemas Operativos",
            "Estructura de Datos",
            "Fundamentos de Sistemas Digitales",
            "Instalaciones Eléctricas y Cableado Estructurado"
        };

        Console.WriteLine("\nMensajes de las asignaturas:");

        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}
