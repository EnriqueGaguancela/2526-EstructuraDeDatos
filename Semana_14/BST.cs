using System; 

namespace BSTConsole
{
    // Clase que representa un Árbol Binario de Búsqueda (BST).
    public class BST
    {
        private Nodo raiz; // Nodo raíz del árbol, punto de entrada.

        // Constructor: inicializa el árbol vacío.
        public BST()
        {
            raiz = null; // No hay nodos inicialmente.
        }

        // INSERCIÓN
        // Inserta un nuevo valor en el árbol.
        public void Insertar(int valor)
        {
            // Llama a la función recursiva de inserción a partir de la raíz.
            raiz = InsertarRecursivo(raiz, valor);
        }

        // Inserción recursiva: encuentra la posición correcta para el nuevo nodo
        private Nodo InsertarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null) // Si el nodo actual es null, se crea uno nuevo.
                return new Nodo(valor);

            // Si el valor es menor que el nodo actual, se va al subárbol izquierdo.
            if (valor < nodo.Valor)
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
            // Si el valor es mayor, se va al subárbol derecho.
            else if (valor > nodo.Valor)
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);

            return nodo; // Devuelve el nodo actualizado.
        }

        // BÚSQUEDA
        // Verifica si un valor existe en el árbol.
        public bool Buscar(int valor)
        {
            return BuscarRecursivo(raiz, valor);
        }

        // Búsqueda recursiva: compara el valor con el nodo actual y decide hacia dónde ir.
        private bool BuscarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null) return false; // Nodo vacío, valor no encontrado.
            if (valor == nodo.Valor) return true; // Valor encontrado.
            if (valor < nodo.Valor) return BuscarRecursivo(nodo.Izquierdo, valor); // Ir izquierda.
            else return BuscarRecursivo(nodo.Derecho, valor); // Ir derecha.
        }

        // ELIMINACIÓN
        // Elimina un valor del árbol.
        public void Eliminar(int valor)
        {
            raiz = EliminarRecursivo(raiz, valor);
        }

        // Eliminación recursiva: encuentra el nodo y lo elimina.
        private Nodo EliminarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null) return null; // Nodo no encontrado.

            if (valor < nodo.Valor)
                nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, valor); // Buscar en izquierda.
            else if (valor > nodo.Valor)
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, valor); // Buscar en derecha.
            else
            {
                // Nodo encontrado.

                // Caso 1: nodo con 0 o 1 hijo.
                if (nodo.Izquierdo == null) return nodo.Derecho;
                if (nodo.Derecho == null) return nodo.Izquierdo;

                // Caso 2: nodo con 2 hijos.
                // Se reemplaza con el sucesor mínimo del subárbol derecho.
                nodo.Valor = MinValor(nodo.Derecho);
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, nodo.Valor);
            }

            return nodo; // Devuelve el nodo actualizado.
        }

        // RECORRIDOS
        // Muestra los valores del árbol en orden (izquierda, raíz, derecha).
        public void RecorridoInorden()
        {
            Console.Write("Inorden: ");
            Inorden(raiz);
            Console.WriteLine();
        }

        private void Inorden(Nodo nodo)
        {
            if (nodo == null) return; 
            Inorden(nodo.Izquierdo);
            Console.Write(nodo.Valor + " "); 
            Inorden(nodo.Derecho);
        }

        // Muestra los valores del árbol en preorden (raíz, izquierda, derecha).
        public void RecorridoPreorden()
        {
            Console.Write("Preorden: ");
            Preorden(raiz);
            Console.WriteLine();
        }

        private void Preorden(Nodo nodo)
        {
            if (nodo == null) return;
            Console.Write(nodo.Valor + " "); // Visita primero el nodo.
            Preorden(nodo.Izquierdo);
            Preorden(nodo.Derecho);
        }

        // Muestra los valores del árbol en postorden (izquierda, derecha, raíz).
        public void RecorridoPostorden()
        {
            Console.Write("Postorden: ");
            Postorden(raiz);
            Console.WriteLine();
        }

        private void Postorden(Nodo nodo)
        {
            if (nodo == null) return;
            Postorden(nodo.Izquierdo);
            Postorden(nodo.Derecho);
            Console.Write(nodo.Valor + " "); // Visita al final
        }

        // VALOR MÍNIMO Y MÁXIMO
        public int MinValor()
        {
            if (raiz == null) throw new InvalidOperationException("El árbol está vacío.");
            Nodo actual = raiz;
            while (actual.Izquierdo != null) actual = actual.Izquierdo;
            return actual.Valor; // Valor mínimo en el BST.
        }

        // Versión privada usada internamente.
        private int MinValor(Nodo nodo)
        {
            Nodo actual = nodo;
            while (actual.Izquierdo != null) actual = actual.Izquierdo;
            return actual.Valor;
        }

        public int MaxValor()
        {
            if (raiz == null) throw new InvalidOperationException("El árbol está vacío.");
            Nodo actual = raiz;
            while (actual.Derecho != null) actual = actual.Derecho;
            return actual.Valor; // Valor máximo en el BST.
        }

        // ALTURA DEL ÁRBOL
        public int Altura()
        {
            return AlturaRecursiva(raiz);
        }

        private int AlturaRecursiva(Nodo nodo)
        {
            if (nodo == null) return 0; // Árbol vacío contribuye 0.
            int izq = AlturaRecursiva(nodo.Izquierdo);  // Altura subárbol izquierdo.
            int der = AlturaRecursiva(nodo.Derecho);    // Altura subárbol derecho.
            return Math.Max(izq, der) + 1; // Altura actual = max(subárboles) + 1.
        }

        // LIMPIAR ÁRBOL
        public void Limpiar()
        {
            raiz = null; // Elimina todos los nodos.
            Console.WriteLine("Árbol eliminado correctamente.");
        }
    }
}