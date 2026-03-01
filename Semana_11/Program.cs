using System;
using System.Collections.Generic;

class Traductor
{
    static void Main()
    {
        // Dicionario inicial; Clave: palabra en español, Valor: traducción al inglés.
        // StringComparer.OrdinalIgnoreCase permite buscar las palabras tomando a consideración mayúsculas/minúsculas.
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"tiempo", "time"},
            {"persona", "person"},
            {"año", "year"},
            {"camino", "way"},
            {"día", "day"},
            {"cosa", "thing"},
            {"hombre", "man"},
            {"mundo", "world"},
            {"vida", "life"},
            {"mano", "hand"},
            {"parte", "part"},
            {"niño", "child"},
            {"ojo", "eye"},
            {"mujer", "woman"},
            {"lugar", "place"},
            {"trabajo", "work"},
            {"semana", "week"},
            {"caso", "case"},
            {"tema", "point"},
            {"gobierno", "government"},
            {"compañía", "company"}
        };

        int opcion; // Almacenamiento de la opción del menú.

        // Menú del sistema.
        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            // Leer la opción escogida por el usuario.
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1; // si no es un número válido, se asigna -1.
            }

            // Evaluar la opción seleccionada del menú.
            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario); // Llmar a la función para traducir frases.
                    break;
                case 2:
                    AgregarPalabra(diccionario); // Llamar a la función para agregar nuevas palabras.
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

        } while (opcion != 0); // El menú se repite varias ocasiones hasta que el usuario elija la opción de salir (0).
    }

    // Función para traducir la frase ingresada.
    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la frase a traducir: ");
        string frase = Console.ReadLine(); // Leer la frase completa.

        string[] palabras = frase.Split(' '); // División de la frase en palabras.
        for (int i = 0; i < palabras.Length; i++)
        {
            string palabraOriginal = palabras[i]; // Guardar la palabra original.

            // Signos de puntuación.
            string signoFinal = ""; // Variable para almacenar signo de puntuación final (si existiera).
            string palabraLimpia = palabraOriginal;

            if (palabraOriginal.Length > 1)
            {
                char ultimo = palabraOriginal[palabraOriginal.Length - 1]; // Obtención el último caracter.
                if (char.IsPunctuation(ultimo)) // Verificación signo de puntuación.
                {
                    signoFinal = ultimo.ToString(); // Guardar el signo de puntuación.
                    palabraLimpia = palabraOriginal.Substring(0, palabraOriginal.Length - 1); // Quitar el signo de puntuación.
                }
            }

            // Traducción utilizando el diccionario.
            // Palabra existe en el diccionario (clave: español).
            if (diccionario.ContainsKey(palabraLimpia))
            {
                string traduccion = diccionario[palabraLimpia]; // Obtención de la traducción en inglés.

                // Mantener mayúscula inicial si la palabra original la tiene.
                if (char.IsUpper(palabraLimpia[0]))
                {
                    traduccion = char.ToUpper(traduccion[0]) + traduccion.Substring(1);
                }

                // Reconstrucción de la palabra con la traducción y el signo de puntuación (si existera).
                palabras[i] = traduccion + signoFinal;
            }
            // Si no se encuentra en el diccionario, se conserva la palabra original.
        }

        // Reconstrucción de la frase completa uniendo las palabras.
        string fraseTraducida = string.Join(" ", palabras);
        Console.WriteLine("Traducción parcial: " + fraseTraducida);
    }

    // Función para agregar nuevas palabras.
    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la palabra en español: ");
        string palabraEsp = Console.ReadLine().Trim(); // Limpiar espacios.

        // Verificar si la palabra existe en el diccionario
        if (diccionario.ContainsKey(palabraEsp))
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
            return; // Salir de la función.
        }

        Console.Write("Ingrese la traducción al inglés: ");
        string traduccion = Console.ReadLine().Trim(); // Limpiar. espacios.

        // Agregar la nueva palabra al diccionario.
        diccionario[palabraEsp] = traduccion;
        Console.WriteLine($"Palabra '{palabraEsp}' agregada con traducción '{traduccion}'.");
    }
}