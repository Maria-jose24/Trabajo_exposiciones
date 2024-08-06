using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{

    public class Dispositivo
    {
        // Método virtual que puede ser sobreescrito por las clases derivadas
        public virtual void Encender()
        {
            Console.WriteLine("El dispositivo está encendido.");
        }
    }
}
