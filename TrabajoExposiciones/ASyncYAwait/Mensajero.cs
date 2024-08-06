using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASyncYAwait
{
    public class Mensajero
    {
        // Método asíncrono que muestra un mensaje después de una breve espera
        public async Task MostrarMensajeAsync()
        {
            // Espera 2 segundos antes de continuar
            await Task.Delay(2000); // Retraso de 2000 milisegundos (2 segundos)
            Console.WriteLine("Mensaje mostrado después de 2 segundos.");
        }
    }
}
