using System;  

// Definición del namespace Figuras para organizar las clases de figuras geométricas.
namespace Figuras
{
    // Definición de la clase Cuadrado.
    class Cuadrado
    {
        // Propiedad pública de la clase.
        // Permite acceder y modificar el valor del lado desde fuera de la clase.
        public double Lado { get; set; }  // Representa la longitud del lado del cuadrado.

        // Se llama cuando se crea un objeto de tipo Cuadrado.
        // Inicializa la propiedad Lado con el valor recibido como parámetro.
        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        // Método para calcular el área del cuadrado, Área = Lado * Lado
        public double CalcularArea()
        {
            return Lado * Lado;
        }

        // Método para calcular el perímetro del cuadrado, Perímetro = 4 * Lado
        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
