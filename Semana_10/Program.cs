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
            HashSet<string> ciudadanos = new HashSet<string>();
            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add("Ciudadano " + i); // "Ciudadano 1", "Ciudadano 2", ...
            }

            // 2. Creación del conjunto de 75 ciudadanos vacunados con Pfizer.
            HashSet<string> vacunadosPfizer = new HashSet<string>();
            Random random = new Random();
            while (vacunadosPfizer.Count < 75)
            {
                int numero = random.Next(1, 501);
                vacunadosPfizer.Add("Ciudadano " + numero);
            }

            // 3. Creación del conjunto de 75 ciudadanos vacunados con AstraZeneca.
            HashSet<string> vacunadosAstraZeneca = new HashSet<string>();
            while (vacunadosAstraZeneca.Count < 75)
            {
                int numero = random.Next(1, 501);
                vacunadosAstraZeneca.Add("Ciudadano " + numero);
            }

            // 4. Aplicación de teoría de conjuntos.

            // a) Ambas dosis = Pfizer ∩ AstraZeneca
            HashSet<string> ambasDosis = new HashSet<string>(vacunadosPfizer);
            ambasDosis.IntersectWith(vacunadosAstraZeneca);

            // b) Solo Pfizer = Pfizer - AstraZeneca
            HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
            soloPfizer.ExceptWith(vacunadosAstraZeneca);

            // c) Solo AstraZeneca = AstraZeneca - Pfizer
            HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
            soloAstraZeneca.ExceptWith(vacunadosPfizer);

            // d) No vacunados = Ciudadanos - todos los vacunados
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunadosPfizer);
            noVacunados.ExceptWith(vacunadosAstraZeneca);

            
            // 5. Mostrar tabla resumen de cantidades
            
            Console.WriteLine("===== TABLA RESUMEN DE VACUNACIÓN =====\n");
            Console.WriteLine("Categoría\t\tCantidad de Ciudadanos");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Total ciudadanos\t\t{ciudadanos.Count}");
            Console.WriteLine($"Vacunados Pfizer\t\t{vacunadosPfizer.Count}");
            Console.WriteLine($"Vacunados AstraZeneca\t{vacunadosAstraZeneca.Count}");
            Console.WriteLine($"No vacunados\t\t\t{noVacunados.Count}");
            Console.WriteLine($"Ambas dosis\t\t\t{ambasDosis.Count}");
            Console.WriteLine($"Solo Pfizer\t\t\t{soloPfizer.Count}");
            Console.WriteLine($"Solo AstraZeneca\t\t{soloAstraZeneca.Count}");
            Console.WriteLine("--------------------------------------------------\n");

            // ===============================
            // 6. Mostrar tabla consolidada de vacunación
            // ===============================
            Console.WriteLine("===== TABLA CONSOLIDADA  =====\n");
            Console.WriteLine("Ciudadano\t\tEstado de Vacunación");
            Console.WriteLine("--------------------------------------------------");

            List<string> listaCiudadanos = ciudadanos.ToList();
            listaCiudadanos.Sort();

            foreach (string ciudadano in listaCiudadanos)
            {
                string estado;

                if (ambasDosis.Contains(ciudadano))
                    estado = "Ambas dosis";
                else if (soloPfizer.Contains(ciudadano))
                    estado = "Solo Pfizer";
                else if (soloAstraZeneca.Contains(ciudadano))
                    estado = "Solo AstraZeneca";
                else
                    estado = "No vacunado";

                Console.WriteLine($"{ciudadano}\t\t{estado}");
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}