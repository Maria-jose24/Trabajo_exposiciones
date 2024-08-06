using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    // Definición de la clase Persona
    public class Persona
    {
        // Propiedades de la clase Persona
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor de la clase Persona
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método para mostrar información de la persona
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Persona
            Persona persona1 = new Persona("Marcela", 35);

            // Llamar al método para mostrar información de la persona
            persona1.MostrarInformacion();

            // Crear otra instancia de la clase Persona
            Persona persona2 = new Persona("Joselo", 52);

            // Llamar al método para mostrar información de la persona
            persona2.MostrarInformacion();
        }
    }
}