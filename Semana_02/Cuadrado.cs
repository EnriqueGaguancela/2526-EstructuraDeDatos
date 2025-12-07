using System;

namespace Figuras
{
    class Cuadrado
    {
        // Propiedad
        public double Lado { get; set; }

        // Constructor
        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        // Método para calcular área
        public double CalcularArea()
        {
            return Lado * Lado;
        }

        // Método para calcular perímetro
        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
