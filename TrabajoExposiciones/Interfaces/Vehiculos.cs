namespace Interfaces
{
    using System;

    // Definición de la interfaz IVehiculo
    public interface IVehiculo
    {
        // Propiedad que debe ser implementada por cualquier clase que implemente esta interfaz
        string Marca { get; set; }

        // Método que debe ser implementado por cualquier clase que implemente esta interfaz
        void Conducir();

        // Método con implementación
        void Detener()
        {
            Console.WriteLine("El vehículo ha sido detenido.");
        }
    }

    // Clase Coche que implementa la interfaz IVehiculo
    public class Coche : IVehiculo
    {
        // Implementación de la propiedad Marca
        public string Marca { get; set; }

        // Implementación del método Conducir
        public void Conducir()
        {
            Console.WriteLine($"El coche {Marca} está conduciendo.");
        }
    }

    // Clase Moto que implementa la interfaz IVehiculo
    public class Moto : IVehiculo
    {
        // Implementación de la propiedad Marca
        public string Marca { get; set; }

        // Implementación del método Conducir
        public void Conducir()
        {
            Console.WriteLine($"La moto {Marca} está conduciendo.");
        }
    }

    // Programa principal
    class Vehiculos
    {
        static void Main()
        {
            // Crear instancias de las clases que implementan la interfaz IVehiculo
            IVehiculo coche = new Coche { Marca = "Toyota" };
            IVehiculo moto = new Moto { Marca = "Yamaha" };

            // Llamar a los métodos definidos en la interfaz
            coche.Conducir();
            coche.Detener();

            moto.Conducir();
            moto.Detener();
        }
    }
}