// Implementar el método de búsqueda en la clase lista, el cual debe retornar el número
// de veces que se encuentre el dato dentro de la lista. En caso de no encontrarse, el método debe
// mostrar un mensaje indicando que el dato no fue encontrado. El parámetro de entrada del método es el valor
// que se desea buscar.
ListaEnlazada lista = new ListaEnlazada();
lista.Agregar(1);       // Agregar elementos a la lista.
lista.Agregar(2);
lista.Agregar(3);
lista.Agregar(5);
lista.Agregar(5);
lista.Agregar(6);
lista.Agregar(7);
lista.Agregar(8);
lista.Agregar(2);
lista.Agregar(0);
lista.Agregar(1);
lista.Agregar(7);
lista.Agregar(1);       
lista.Agregar(4);
lista.Agregar(3);
lista.Agregar(8);
lista.Agregar(5);
lista.Agregar(6);
lista.Agregar(7);
lista.Agregar(8);
lista.Agregar(9);
lista.Agregar(1);
lista.Agregar(0);
lista.Agregar(7);

lista.Mostrar();

Console.Write("Ingresa un número entre 0 y 9 para buscar en la lista: ");
string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int numeroBuscado) && numeroBuscado >= 0 && numeroBuscado <= 9)
{
    lista.Buscar(numeroBuscado);
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, ingresa un número entre 0 y 9.");
}
