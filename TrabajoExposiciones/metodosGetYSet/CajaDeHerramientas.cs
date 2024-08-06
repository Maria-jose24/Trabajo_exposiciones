using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosGetYSet
{
    public class CajaDeHerramientas
    {
        // Lista privada para almacenar herramientas
        private List<string> herramientas = new List<string>();

        // Propiedad para obtener el número de herramientas en la caja
        public int NumeroDeHerramientas
        {
            get { return herramientas.Count; }
        }

        // Método para añadir una herramienta a la caja
        public void AñadirHerramienta(string herramienta)
        {
            if (!herramientas.Contains(herramienta))
            {
                herramientas.Add(herramienta);
                Console.WriteLine($"{herramienta} añadida a la caja.");
            }
            else
            {
                Console.WriteLine($"{herramienta} ya está en la caja.");
            }
        }

        // Método para eliminar una herramienta de la caja
        public void EliminarHerramienta(string herramienta)
        {
            if (herramientas.Remove(herramienta))
            {
                Console.WriteLine($"{herramienta} eliminada de la caja.");
            }
            else
            {
                Console.WriteLine($"{herramienta} no se encontró en la caja.");
            }
        }

        // Método para listar todas las herramientas en la caja
        public void ListarHerramientas()
        {
            Console.WriteLine("Herramientas en la caja:");
            foreach (var herramienta in herramientas)
            {
                Console.WriteLine($"- {herramienta}");
            }
        }
    }
}