public class Hanoi
{
    private Stack<int> origen;
    private Stack<int> auxiliar;
    private Stack<int> destino;

    public Hanoi(int numDiscos)
    {
        origen = new Stack<int>();
        auxiliar = new Stack<int>();
        destino = new Stack<int>();

        for (int i = numDiscos; i >= 1; i--)       // Llenar la torre de origen con los discos, el más grande abajo.
        {
            origen.Push(i);
        }

        Console.WriteLine("\nEstado inicial:");       // Mostrar el estado inicial.
        MostrarTorres();
        Console.WriteLine();

        MoverDiscos(numDiscos, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");

        
        Console.WriteLine("\nEstado final:");       // Mostrar el estado final.
        MostrarTorres();
    }

    private void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                             string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            return;
        }

        MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);

        int discoMovido = origen.Pop();
        destino.Push(discoMovido);
        Console.WriteLine($"Mover disco {discoMovido} de {nombreOrigen} a {nombreDestino}");

        MoverDiscos(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
    }

    private void MostrarTorres()
    {
        Console.WriteLine("Torre Origen   : " + string.Join(", ", origen.ToArray()));
        Console.WriteLine("Torre Auxiliar : " + string.Join(", ", auxiliar.ToArray()));
        Console.WriteLine("Torre Destino  : " + string.Join(", ", destino.ToArray()));
    }
}
