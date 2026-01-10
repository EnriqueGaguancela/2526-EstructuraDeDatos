using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear(); // Limpia pantalla cada vez que se muestra el menú
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================");
            Console.WriteLine("         MENÚ DE EJERCICIOS         ");
            Console.WriteLine("====================================");
            Console.ResetColor();

            Console.WriteLine("1. Lista de asignaturas");
            Console.WriteLine("2. Mensaje 'Yo estudio <asignatura>'");
            Console.WriteLine("3. Números del 1 al 10 en orden inverso");
            Console.WriteLine("4. Contar vocales de una palabra");
            Console.WriteLine("5. Verificar palíndromo");
            Console.WriteLine("0. Salir");

            Console.Write("\nSeleccione una opción (0-5): ");
            string? input = Console.ReadLine();
            string opcion = input?.Trim() ?? ""; // Evita null y elimina espacios

            Console.WriteLine(); // Línea en blanco antes de ejecutar

            switch (opcion)
            {
                case "1":
                    Ejercicio_1.Ejecutar();
                    break;
                case "2":
                    Ejercicio_2.Ejecutar();
                    break;
                case "3":
                    Ejercicio_3.Ejecutar();
                    break;
                case "4":
                    Ejercicio_4.Ejecutar();
                    break;
                case "5":
                    Ejercicio_5.Ejecutar();
                    break;
                case "0":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("¡Gracias!");
                    Console.ResetColor();
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("\nPresione ENTER para volver al menú...");
            Console.ReadLine(); // Pausa antes de volver al menú
        }
    }
}
