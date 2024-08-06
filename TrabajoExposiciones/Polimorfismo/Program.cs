namespace Polimorfismo
{
    class Program
    {
        static void Main()
        {
            // Crear instancias de Telefono y Computadora
            Dispositivo miTelefono = new Telefono();
            Dispositivo miComputadora = new Computadora();

            // Llamar al método Encender en diferentes tipos de objetos
            miTelefono.Encender();      // Salida: El teléfono está encendido y listo para recibir llamadas.
            miComputadora.Encender();  // Salida: La computadora está encendida y cargando el sistema operativo.
        }
    }
}
