using System;
using System.Collections.Generic;

namespace MiBiblioteca
{
    // Creación de la clase Biblioteca.
    public class Biblioteca
    {
        // Diccionario para almacenar libros con clave ISBN.
        private Dictionary<string, Libro> libros = new Dictionary<string, Libro>();

        // Conjunto para almacenar géneros sin duplicados.
        private HashSet<string> generos = new HashSet<string>();

        // Método para registrar un nuevo libro.
        public void RegistrarLibro()
        {
            Console.Write("Ingrese ISBN: ");
            string isbn = Console.ReadLine();

            // Validación para que el ISBN no se encuentre vacío.
            // ISBN, es el Número Internacional Normalizado del Libro (del inglés International Standard Book Number).
            // Es un código único que identifica un libro específico en el mundo editorial.
            if (string.IsNullOrWhiteSpace(isbn))
            {
                Console.WriteLine("El ISBN no puede estar vacío.");
                return;
            }

            // Verificación si el libro ya se encuentra registrado con ISBN.
            if (libros.ContainsKey(isbn))
            {
                Console.WriteLine("El libro ya se encuentra registrado.");
                return;
            }

            // Solicitar datos para agregar un libro.
            Console.Write("Ingrese título: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese género: ");
            string genero = Console.ReadLine();

            // Creación del objeto libro.
            Libro nuevoLibro = new Libro(titulo, autor, genero);

            // Agregar libro al diccionario y género al conjunto.
            libros.Add(isbn, nuevoLibro);
            generos.Add(genero);

            Console.WriteLine("Libro registrado exitosamente.");
        }

        // Método para mostrar todos los libros registrados.
        public void MostrarLibros()
        {
            // Validación para saber si existen libros registrados.
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
                return;
            }

            Console.WriteLine("\nLibros registrados:");

            // Recorrer y mostrar cada libro con su respectiva información.
            foreach (var libro in libros)
            {
                Console.WriteLine("ISBN: " + libro.Key);
                Console.WriteLine("Título: " + libro.Value.Titulo);
                Console.WriteLine("Autor: " + libro.Value.Autor);
                Console.WriteLine("Género: " + libro.Value.Genero);
                Console.WriteLine("---------------------------");
            }
        }

        // Método para mostrar los géneros disponibles sin duplicados.
        public void MostrarGeneros()
        {
            // Validación para saber si existen géneros registrados.
            if (generos.Count == 0)
            {
                Console.WriteLine("No hay géneros registrados.");
                return;
            }

            Console.WriteLine("\nGéneros disponibles:");

            // Recorrer y mostrar cada género.
            foreach (string g in generos)
            {
                Console.WriteLine(g);
            }
        }
    }
}