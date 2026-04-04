using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Crear instancia de grafo para manejo de vuelos.
        Grafo vuelos = new Grafo();

        // Ruta donde se encuentra el archivo vuelos.txt
        string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vuelos.txt");

        // Cargar vuelos desde el archivo al iniciar el programa.
        vuelos.CargarDesdeArchivo(rutaArchivo);

        while (true)
        {
            // Mostrar menú de opciones.
            Console.WriteLine("\n--- MENÚ DE VUELOS ---");
            Console.WriteLine("1. Mostrar todos los vuelos");
            Console.WriteLine("2. Agregar un nuevo vuelo");
            Console.WriteLine("3. Encontrar vuelo más barato");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine().Trim();

            if (opcion == "1")
            {
                // Mostrar los vuelos disponibles.
                vuelos.MostrarTodosLosVuelos();
            }
            else if (opcion == "2")
            {
                // Agregar nuevo vuelo, el valor de vuelo debe ingresarse sin el símbolo de moneda.
                Console.Write("Ingrese ciudad de origen: ");
                string origen = Console.ReadLine().Trim();
                Console.Write("Ingrese ciudad de destino: ");
                string destino = Console.ReadLine().Trim();
                Console.Write("Ingrese precio del vuelo: ");

                // Validar que el precio sea un número válido, el valor de vuelo debe ingresarse sin el símbolo de moneda.
                if (int.TryParse(Console.ReadLine().Trim(), out int precio))
                {
                    // Agregar vuelo en memoria y guardarlo en archivo.
                    vuelos.AgregarVuelo(origen, destino, precio);
                    vuelos.GuardarVueloEnArchivo(rutaArchivo, origen, destino, precio);
                    Console.WriteLine("✅ Vuelo agregado correctamente y guardado en archivo.");
                }
                else
                {
                    Console.WriteLine("❌ Precio inválido.");
                }
            }
            else if (opcion == "3")
            {
                // Solicitar ciudades para buscar vuelo más económico.
                Console.Write("Ingrese ciudad de origen: ");
                string origen = Console.ReadLine().Trim();
                Console.Write("Ingrese ciudad de destino: ");
                string destino = Console.ReadLine().Trim();

                // Mostrar la ruta más económica.
                vuelos.EncontrarVueloMasBarato(origen, destino);
            }
            else if (opcion == "4")
            {
                // Salir del programa.
                Console.WriteLine("---Gracias por usar el sistema---");
                break;
            }
            else
            {
                // Opción inválida dentro del menú.
                Console.WriteLine("Opción inválida. Intente de nuevo.");
            }
        }
    }
}