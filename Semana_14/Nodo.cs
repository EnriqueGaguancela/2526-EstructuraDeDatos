namespace BSTConsole
{
    // Clase Nodo: representa un nodo del árbol
    public class Nodo
    {
        public int Valor;       // Valor almacenado en el nodo.
        public Nodo Izquierdo;  // Referencia al hijo izquierdo.
        public Nodo Derecho;    // Referencia al hijo derecho.

        // Constructor: inicializa el nodo con un valor.
        public Nodo(int valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }
    }
}