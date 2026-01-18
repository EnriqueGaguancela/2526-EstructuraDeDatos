// Función que calcule el número de elementos de una lista.
ListaEnlazada lista = new ListaEnlazada();
lista.Agregar(1);       // Agregar elementos a la lista.
lista.Agregar(2);
lista.Agregar(3);
lista.Agregar(4);
lista.Agregar(5);
lista.Agregar(6);
lista.Agregar(7);
lista.Agregar(8);
lista.Agregar(9);
lista.Agregar(0);

lista.Mostrar();

int longitud = lista.Longitud();
Console.WriteLine("La longitud de la lista actual es de: " + longitud);