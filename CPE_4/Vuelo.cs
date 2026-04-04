// Clase que representa un vuelo con destino y precio.
class Vuelo
{
    // Propiedad para guardar el destino del vuelo.
    public string Destino { get; set; }

    // Propiedad para guardar el precio del vuelo.
    public int Precio { get; set; }

    // Constructor para inicializar un vuelo con destino y precio.
    public Vuelo(string destino, int precio)
    {
        Destino = destino;
        Precio = precio;
    }
}