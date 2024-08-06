namespace PrincipioSolid
{
    class Program
    {
        static void Main()
        {
            // Crear un nuevo producto
            Producto producto = new Producto("Laptop", 1000.00m);

            // Crear un registro de cambios
            RegistroCambios registro = new RegistroCambios();

            // Mostrar la información del producto
            Console.WriteLine("Información inicial del producto:");
            Console.WriteLine($"Nombre del Producto: {producto.Nombre}");
            Console.WriteLine($"Precio del Producto: {producto.Precio:C}");

            // Cambiar el precio del producto
            decimal precioAnterior = producto.Precio;
            producto.CambiarPrecio(900.00m);

            // Registrar el cambio de precio
            registro.RegistrarCambio(producto, precioAnterior);
        }
    }
}