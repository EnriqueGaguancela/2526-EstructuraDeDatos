// Namespace que agrupa las clases relacionadas con la biblioteca.
namespace MiBiblioteca
{
    // Clase que representa un libro con sus propiedades.
    public class Libro
    {
        // Título del libro
        public string Titulo { get; set; }

        // Autor del libro
        public string Autor { get; set; }

        // Género literario del libro.
        public string Genero { get; set; }

        // Constructor que inicializa las propiedades del libro.
        public Libro(string titulo, string autor, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
        }
    }
}