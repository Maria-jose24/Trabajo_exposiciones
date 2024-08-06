using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid
{
    public class Producto
    {
        public string Nombre { get; private set; }
        public decimal Precio { get; private set; }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public void CambiarPrecio(decimal nuevoPrecio)
        {
            Precio = nuevoPrecio;
        }
    }
}
