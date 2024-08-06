using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class PerfilUsuario
    {
        // Campos privados
        private string nombre;
        private int edad;

        // Constructor
        public PerfilUsuario(string nombreInicial, int edadInicial)
        {
            nombre = nombreInicial;
            edad = edadInicial;
        }

        // Propiedad pública para acceder al nombre
        public string Nombre
        {
            get { return nombre; } // Permite leer el nombre
            set { nombre = value; } // Permite modificar el nombre
        }

        // Propiedad pública para acceder a la edad
        public int Edad
        {
            get { return edad; } // Permite leer la edad
        }

        // Método público para mostrar la información del usuario
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
        }
    }
}