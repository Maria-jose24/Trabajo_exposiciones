using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Vehiculo
    {
        // Propiedad que todos los vehículos tienen
        public string Modelo { get; set; }

        // Método que todos los vehículos pueden realizar
        public void Arrancar()
        {
            Console.WriteLine($"{Modelo} está arrancando.");
        }
    }
}