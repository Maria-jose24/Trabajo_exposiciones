namespace ASyncYAwait
{
    class Program
    {
        static async Task Main()
        {
            // Crear una instancia de la clase Mensajero
            Mensajero mensajero = new Mensajero();

            // Llamar al método asíncrono y esperar a que termine
            await mensajero.MostrarMensajeAsync(); // Espera a que el mensaje sea mostrado

            Console.WriteLine("Programa terminado.");
        }
    }
}