namespace Herencia
{
    class Program
    {
        static void Main()
        {
            // Crear una instancia de la clase Camion
            Camion miCamion = new Camion();
            miCamion.Modelo = "Volvo FH16";

            // Llamar a métodos heredados y específicos
            miCamion.Arrancar(); // Método heredado de Vehiculo
            miCamion.Cargar();   // Método específico de Camion
        }
    }
}
