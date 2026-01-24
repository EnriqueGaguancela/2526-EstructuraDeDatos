public class Ejercicio
{
    public bool EsBalanceada(string expresion)       // Función para verificar si la expresión se encuentra blalanceada.
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {

            if (c == '(' || c == '[' || c == '{')       // Símbolos de apertura.
            {
                pila.Push(c);
            }

            else if (c == ')' || c == ']' || c == '}')       // Símbolos de cierre.
            {
                
                if (pila.Count == 0)
                {
                    return false;
                }

                char tope = pila.Pop();       // Obtener el último símbolo de la pila.

                if ((c == ')' && tope != '(') ||       // Comprobar que coincida los símbolos.
                    (c == ']' && tope != '[') ||
                    (c == '}' && tope != '{'))
                {
                    return false;
                }
            }
        }

        return pila.Count == 0;       // Si la pila está vacía al final, la expresión se encuentra balanceada.
    }
}
