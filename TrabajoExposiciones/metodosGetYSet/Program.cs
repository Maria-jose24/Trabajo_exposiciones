namespace metodosGetYSet
{
    class Program
    {
        static void Main()
        {
            // Crear una instancia de la clase CajaDeHerramientas
            CajaDeHerramientas caja = new CajaDeHerramientas();

            // Añadir herramientas a la caja
            caja.AñadirHerramienta("Martillo");
            caja.AñadirHerramienta("Destornillador");
            caja.AñadirHerramienta("Alicates");

            // Listar herramientas en la caja
            caja.ListarHerramientas();

            // Eliminar una herramienta de la caja
            caja.EliminarHerramienta("Destornillador");

            // Listar herramientas después de la eliminación
            Console.WriteLine("\nDespués de eliminar el destornillador:");
            caja.ListarHerramientas();

            // Intentar añadir una herramienta que ya está en la caja
            caja.AñadirHerramienta("Martillo");
        }
    }
}