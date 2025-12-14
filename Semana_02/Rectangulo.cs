using System;  

// Definición de Figuras para organizar las clases relacionadas.
namespace Figuras
{
    // Definición de la clase Rectangulo
    class Rectangulo
    {
        // Propiedades públicas de la clase, pPermiten acceder y modificar los valores desde fuera de la clase.
        public double Base { get; set; }   // Representa la base del rectángulo.
        public double Altura { get; set; } // Representa la altura del rectángulo.

        
        // Llama cuando se crea un objeto de tipo Rectangulo.
        // Inicializa las propiedades Base y Altura con los valores recibidos como parámetros.
        public Rectangulo(double b, double a)
        {
            Base = b;
            Altura = a;
        }

        // Método para calcular el área del rectángulo, Área = Base * Altura
        public double CalcularArea()
        {
            return Base * Altura;
        }

        // Método para calcular el perímetro del rectángulo, Perímetro = 2 * (Base + Altura)
        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
