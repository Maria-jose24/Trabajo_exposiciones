using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class CalculadoraSimple
    {
        // Función para sumar dos números
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        // Función para restar dos números
        public double Restar(double a, double b)
        {
            return a - b;
        }

        // Función para multiplicar dos números
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Función para dividir dos números
        // Incluye manejo de errores para la división por cero
        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: División por cero no permitida.");
                return double.NaN; // Retorna NaN para indicar un error
            }
            return a / b;
        }
    }
}