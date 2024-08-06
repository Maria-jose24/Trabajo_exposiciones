using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Computadora : Dispositivo
    {
        // Sobreescribe el método Encender
        public override void Encender()
        {
            Console.WriteLine("La computadora está encendida y cargando el sistema operativo.");
        }
    }
}
