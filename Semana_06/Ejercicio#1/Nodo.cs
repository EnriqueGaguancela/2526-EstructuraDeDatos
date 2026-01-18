class Nodo       // Clase nodo, la misma que representa a un elemnto de una lista.
{
    public int Valor;       // Valor el cual va a contener el nodo.
    public Nodo Siguiente;       // Indicador al siguiente nodo.

    public Nodo(int valor)       // Constructor para inicializar un nodo con un determinada valor.
    {
        Valor = valor;
        Siguiente = null;       // De forma predeterminada, el siguiente nodo es null.
    }
}