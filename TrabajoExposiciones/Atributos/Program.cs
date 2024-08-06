using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    class Program
    {
        static void Main()
        {
            // Crear una instancia de la clase Rectangulo
            Rectangulo rectangulo = new Rectangulo(5.0, 3.0);

            // Calcular y mostrar el área
            double area = rectangulo.CalcularArea();
            Console.WriteLine($"Área del rectángulo: {area}");

            // Calcular y mostrar el perímetro
            double perimetro = rectangulo.CalcularPerimetro();
            Console.WriteLine($"Perímetro del rectángulo: {perimetro}");
        }
    }
}