using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Camion : Vehiculo
    {
        // Método específico para Camion
        public void Cargar()
        {
            Console.WriteLine($"{Modelo} está cargando.");
        }
    }
}