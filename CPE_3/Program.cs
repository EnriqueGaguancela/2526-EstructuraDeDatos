using System;
using MiBiblioteca;  // Importar el namespace con las clases Biblioteca y Libro

// Clase principal.
class Program
{
    static void Main()
    {
        // Creación de la instancia Biblioteca.
        Biblioteca biblioteca = new Biblioteca();
        int opcion;

        // Menú principal.
        do
        {
            Console.WriteLine("\n=== BIBLIOTECA ===");
            Console.WriteLine("1. Registrar nuevo libro");
            Console.WriteLine("2. Mostrar libros disponibles");
            Console.WriteLine("3. Mostrar géneros");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            // Leer opción y validar entrada.
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;  // Volver al menú si la entrada es incorrecta.
            }

            // Ejecutar de acuerdo a la opción elegida.
            switch (opcion)
            {
                case 1:
                    biblioteca.RegistrarLibro();
                    break;

                case 2:
                    biblioteca.MostrarLibros();
                    break;

                case 3:
                    biblioteca.MostrarGeneros();
                    break;

                case 4:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4);  // Repetir hasta que el usuario decida salir.
    }
}