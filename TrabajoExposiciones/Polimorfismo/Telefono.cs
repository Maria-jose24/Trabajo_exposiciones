using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Telefono : Dispositivo
    {
        // Sobreescribe el método Encender
        public override void Encender()
        {
            Console.WriteLine("El teléfono está encendido y listo para recibir llamadas.");
        }
    }
}
