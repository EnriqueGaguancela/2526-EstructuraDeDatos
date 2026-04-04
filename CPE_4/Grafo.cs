using System;
using System.Collections.Generic;
using System.IO;

// Clase que representa el grafo de vuelos y sus operaciones.
class Grafo
{
    // Diccionario que almacena lista de vuelos para cada ciudad de origen.
    private Dictionary<string, List<Vuelo>> adyacencia = new Dictionary<string, List<Vuelo>>();

    // Método para agregar un vuelo al grafo en memoria
    public void AgregarVuelo(string origen, string destino, int precio)
    {
        // Si el origen no está en el diccionario, inicializa la lista de vuelos.
        if (!adyacencia.ContainsKey(origen))
            adyacencia[origen] = new List<Vuelo>();

        // Agregar el vuelo a la lista de vuelos del origen.
        adyacencia[origen].Add(new Vuelo(destino, precio));
    }

    // Método para guardar un vuelo en el archivo de texto.
    public void GuardarVueloEnArchivo(string ruta, string origen, string destino, int precio)
    {
        try
        {
            // Escribir el vuelo en formato CSV: origen,destino,precio
            File.AppendAllText(ruta, $"{origen},{destino},{precio}{Environment.NewLine}");
        }
        catch (Exception e)
        {
            // Mostrar mensaje en caso de error al escribir en el archivo.
            Console.WriteLine("❌ Error al guardar en archivo: " + e.Message);
        }
    }

    // Método para cargar vuelos desde el archivo de texto al grafo en memoria.
    public void CargarDesdeArchivo(string ruta)
    {
        // Crea el archivo vuelos.txt en caso que no existiera.
        if (!File.Exists(ruta))
        {
            Console.WriteLine("⚠ Archivo vuelos.txt no encontrado, se creará al guardar nuevos vuelos.");
            return;
        }

        try
        {
            // Leer todas las líneas desded archivo de texto.
            foreach (var linea in File.ReadAllLines(ruta))
            {
                // Ignorar líneas vacías.
                if (string.IsNullOrWhiteSpace(linea)) continue;

                // Separar la línea por comas para obtener origen, destino y precio.
                var partes = linea.Split(',');
                if (partes.Length != 3) continue; // Línea malformada

                string origen = partes[0].Trim();
                string destino = partes[1].Trim();

                // Convertir el precio a entero, si falla el sistema ignora la línea.
                if (!int.TryParse(partes[2], out int precio)) continue;

                // Agregar el vuelo a la estructura en memoria.
                AgregarVuelo(origen, destino, precio);
            }

            Console.WriteLine("✅ Vuelos cargados correctamente.");
        }
        catch (Exception e)
        {
            // Mostrar mensaje en caso de presentar algún error al leer el archivo.
            Console.WriteLine("❌ Error al leer archivo: " + e.Message);
        }
    }

    // Método para visualizar los vuelos disponibles.
    public void MostrarTodosLosVuelos()
    {
        Console.WriteLine("\n--- Vuelos disponibles ---");
        // Recorrer cada ciudad de origen.
        foreach (var origen in adyacencia.Keys)
        {
            // Recorr todos los vuelos que salen desde la ciudad de origen.
            foreach (var vuelo in adyacencia[origen])
            {
                Console.WriteLine($"{origen} -> {vuelo.Destino} : ${vuelo.Precio}");
            }
        }
    }

    // Método para encontrar la ruta más económica entre dos ciudades (Dijkstra).
    public void EncontrarVueloMasBarato(string inicio, string destino)
    {
        // Diccionario para almacenar el costo mínimo hasta cada nodo.
        var costos = new Dictionary<string, int>();

        // Diccionario para almacenar el nodo anterior en la ruta más económica.
        var anteriores = new Dictionary<string, string>();

        // Conjunto de nodos ya visitados.
        var visitados = new HashSet<string>();

        // Inicializar costos a infinito (máximo entero).
        foreach (var nodo in adyacencia.Keys)
            costos[nodo] = int.MaxValue;

        // Verificar que el nodo de inicio existe.
        if (!costos.ContainsKey(inicio))
        {
            Console.WriteLine("❌ Origen no encontrado.");
            return;
        }

        // El costo de iniciar desde el nodo inicio (0).
        costos[inicio] = 0;

        while (true)
        {
            string actual = null;
            int menorCosto = int.MaxValue;

            // Elegir el nodo no visitado con menor costo.
            foreach (var nodo in costos)
            {
                if (!visitados.Contains(nodo.Key) && nodo.Value < menorCosto)
                {
                    menorCosto = nodo.Value;
                    actual = nodo.Key;
                }
            }

            // Finalizar en caso que no exista nodo para procesar.
            if (actual == null) break;

            // Marcar el nodo actual como visitado.
            visitados.Add(actual);

            // Si no tiene vecinos, seguir con el siguiente nodo.
            if (!adyacencia.ContainsKey(actual)) continue;

            // Recorrer los vecinos del nodo actual.
            foreach (var vecino in adyacencia[actual])
            {
                int nuevoCosto = costos[actual] + vecino.Precio;

                // Si se encuentra un camino más económico, se actualiza costos y ruta anterior.
                if (!costos.ContainsKey(vecino.Destino) || nuevoCosto < costos[vecino.Destino])
                {
                    costos[vecino.Destino] = nuevoCosto;
                    anteriores[vecino.Destino] = actual;
                }
            }
        }

        // Si el destino no se pudo alcanzar, informamos.
        if (!costos.ContainsKey(destino) || costos[destino] == int.MaxValue)
        {
            Console.WriteLine($"❌ No hay ruta disponible de {inicio} a {destino}.");
            return;
        }

        // Visualizar el costo mínimo encontrado.
        Console.WriteLine($"\nCosto mínimo: ${costos[destino]}");

        // Reconstruir la ruta desde destino a inicio usando el diccionario 'anteriores'.
        var ruta = new List<string>();
        string temp = destino;
        while (temp != null)
        {
            ruta.Insert(0, temp);
            anteriores.TryGetValue(temp, out temp);
        }

        // Visualizar ruta completa.
        Console.WriteLine("Ruta: " + string.Join(" -> ", ruta));
    }
}