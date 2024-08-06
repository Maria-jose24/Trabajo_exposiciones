using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class MisterioNumerico
    {
        private int numero;

        // Constructor
        public MisterioNumerico(int numero)
        {
            this.numero = numero;
        }

        // Método para verificar si el número es primo
        public bool EsPrimo()
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        // Método para calcular la suma de los dígitos del número
        public int SumaDeDigitos()
        {
            int suma = 0;
            int temp = numero;
            while (temp > 0)
            {
                suma += temp % 10;
                temp /= 10;
            }
            return suma;
        }


        // Método para mostrar información interesante sobre el número
        public void MostrarInformacion()
        {
            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Es primo: {EsPrimo()}");
            Console.WriteLine($"Suma de dígitos: {SumaDeDigitos()}");
        }
    }
}