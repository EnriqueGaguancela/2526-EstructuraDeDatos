using System;
using System.Collections.Generic;
using System.Linq;

namespace VacunacionCOVID
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Creación del conjunto de 500 ciudadanos ficticios.
            
            // HashSet para asegurar que no existan elementos duplicados.
            HashSet<string> ciudadanos = new HashSet<string>();

            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add("Ciudadano " + i); // Genera "Ciudadano 1", "Ciudadano 2", etc.
            }

             // 2. Creación del conjunto de 75 ciudadanos vacunados con Pfizer.
            
            HashSet<string> vacunadosPfizer = new HashSet<string>();
            Random random = new Random();

            // Llenar el conjunto hasta obtener 75 ciudadanos
            while (vacunadosPfizer.Count < 75)
            {
                int numero = random.Next(1, 501); // Número aleatorio entre 1 y 500
                vacunadosPfizer.Add("Ciudadano " + numero); // Asegurar que no existan datos repetidos.
            }

            // 3. Creación del conjunto de 75 ciudadanos vacunados con AstraZeneca.
            // ===============================
            HashSet<string> vacunadosAstraZeneca = new HashSet<string>();

            while (vacunadosAstraZeneca.Count < 75)
            {
                int numero = random.Next(1, 501); // Número aleatorio entre 1 y 500
                vacunadosAstraZeneca.Add("Ciudadano " + numero); // Asegurar que no existan datos repetidos.
            }

            // Aplicación de teoría de conjuntos.
            

            // a) Unión de vacunados (todos los que tienen al menos una dosis).
            HashSet<string> vacunados = new HashSet<string>(vacunadosPfizer);
            vacunados.UnionWith(vacunadosAstraZeneca);

            // b) No vacunados = ciudadanos - vacunados.
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunados);

            // c) Ambas dosis = intersección de Pfizer y AstraZeneca.
            HashSet<string> ambasDosis = new HashSet<string>(vacunadosPfizer);
            ambasDosis.IntersectWith(vacunadosAstraZeneca);

            // d) Solo Pfizer = Pfizer - AstraZeneca.
            HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
            soloPfizer.ExceptWith(vacunadosAstraZeneca);

            // e) Solo AstraZeneca = AstraZeneca - Pfizer.
            HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
            soloAstraZeneca.ExceptWith(vacunadosPfizer);

            // Visualización de resultados.
            
            Console.WriteLine("TOTAL CIUDADANOS: " + ciudadanos.Count);
            Console.WriteLine("TOTAL VACUNADOS PFIZER: " + vacunadosPfizer.Count);
            Console.WriteLine("TOTAL VACUNADOS ASTRAZENECA: " + vacunadosAstraZeneca.Count);
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("NO VACUNADOS: " + noVacunados.Count);
            Console.WriteLine("VACUNADOS CON AMBAS DOSIS: " + ambasDosis.Count);
            Console.WriteLine("SOLO PFIZER: " + soloPfizer.Count);
            Console.WriteLine("SOLO ASTRAZENECA: " + soloAstraZeneca.Count);

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}