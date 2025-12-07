using System;

namespace Figuras
{
    class Rectangulo
    {
        // Propiedades
        public double Base { get; set; }
        public double Altura { get; set; }

        // Constructor
        public Rectangulo(double b, double a)
        {
            Base = b;
            Altura = a;
        }

        // Método para calcular área
        public double CalcularArea()
        {
            return Base * Altura;
        }

        // Método para calcular perímetro
        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
