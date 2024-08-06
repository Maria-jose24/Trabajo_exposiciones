using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Circulo : Figura
    {
        // Implementación del método Dibujar
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un círculo.");
        }
    }
}