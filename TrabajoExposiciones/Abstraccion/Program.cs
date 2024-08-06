namespace Abstraccion
{
    class Program
    {
        static void Main()
        {
            // Crear una instancia de la clase derivada
            Figura figura = new Circulo();

            // Llamar al método abstracto implementado
            figura.Dibujar(); // Muestra: Dibujando un círculo.
        }
    }
}
