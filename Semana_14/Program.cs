using System;

namespace BSTConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST(); // Crear una instancia del Árbol Binario de Búsqueda (BST).
            bool salir = false;  // Variable para controlar el bucle del menú

            // Menú interactivo.
            while (!salir)
            {
                // Opciones del menú.
                Console.WriteLine("\n--- Árbol Binario de Búsqueda (BST) ---");
                Console.WriteLine("1. Insertar valor");
                Console.WriteLine("2. Buscar valor");
                Console.WriteLine("3. Eliminar valor");
                Console.WriteLine("4. Mostrar recorridos");
                Console.WriteLine("5. Mostrar valor mínimo, máximo y altura");
                Console.WriteLine("6. Limpiar árbol");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine(); // Leer la opción seleccionada.
                switch (opcion) // Seleccionar acción de acuerdo a la opción selecionada.
                {
                    case "1": // Insertar valor.
                        Console.Write("Ingrese el valor a insertar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorInsert)) // Validar que sea un número.
                            bst.Insertar(valorInsert); // Llamar al método de inserción.
                        else
                            Console.WriteLine("Ingrese un número válido."); // Mensaje de error.
                        break;

                    case "2": // Búsqueda de valor.
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorBuscar))
                            Console.WriteLine(bst.Buscar(valorBuscar) ? "Valor encontrado" : "Valor no encontrado");
                        else
                            Console.WriteLine("Ingrese un número válido.");
                        break;

                    case "3": // Eliminar valor
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorEliminar))
                            bst.Eliminar(valorEliminar);
                        else
                            Console.WriteLine("Ingrese un número válido.");
                        break;

                    case "4": // Mostrar recorridos del árbol.
                        bst.RecorridoInorden();   // Inorden: muestra los valores ordenados.
                        bst.RecorridoPreorden();  // Preorden: muestra la raíz primero.
                        bst.RecorridoPostorden(); // Postorden: muestra las hojas primero.
                        break;

                    case "5": // Mostrar información del árbol.
                        try
                        {
                            Console.WriteLine("Valor mínimo: " + bst.MinValor());
                            Console.WriteLine("Valor máximo: " + bst.MaxValor());
                            Console.WriteLine("Altura del árbol: " + bst.Altura());
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "6": // Limpiar árbol.
                        bst.Limpiar();
                        break;

                    case "7": // Salir del programa.
                        salir = true;
                        break;

                    default: // Opción inválida.
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
    }
}