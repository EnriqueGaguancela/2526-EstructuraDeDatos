class ListaEnlazada       // Creación de la clase "ListaEnlazada".
{
    public Nodo Cabeza;       // Primer nodo inicial de la lista.

    public ListaEnlazada()       // Costructor para inicializar una lista vacía.
    {
        Cabeza = null;
    }

    public void Agregar(int valor)       // Agregar un nuevo nodo al final de la lista.
    {
        Nodo nuevo = new Nodo(valor);       // Creación de un nuevo nodo con un valor asignado.

        if (Cabeza == null)
        {
            Cabeza = nuevo;       // Convertir el nodo en la cabeza si la lista se encuentra vacía.            
        }
        else
        {
            Nodo actual = Cabeza;       // Si la lista contiene elementos asiganados, recorrer hacia el último nodo.
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;       // Continuar con el nodo siguiente.                
            }
            actual.Siguiente = nuevo;       // Vincular el último nodo con el nuevo nodo.
        }
    }

    public int Longitud()       // Calcular la longitud de la lista.
    {
        int contador = 0;       // Inicializar el contador de nodos.
        Nodo actual = Cabeza;       // Empezar el conteo desde la cabeza de la lista (primer valor).

        while (actual != null)
        {
            contador++;       // Contador del nodo actual.
            actual = actual.Siguiente;       // Avanzar al siguiente nodo
        }
        return contador;
    }

    public void Mostrar()       // Impresión de la lista generada.
    {
        Nodo actual = Cabeza;

        Console.Write("head ==>");
        while (actual != null)
        {
            Console.Write($"[{actual.Valor} | * ] ==> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null\n");
    }
}