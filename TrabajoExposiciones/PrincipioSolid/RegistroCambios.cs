using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid
{
    public class RegistroCambios
    {
        public void RegistrarCambio(Producto producto, decimal precioAnterior)
        {
            Console.WriteLine($"El precio del producto '{producto.Nombre}' cambió de {precioAnterior:C} a {producto.Precio:C}");
        }
    }
}
