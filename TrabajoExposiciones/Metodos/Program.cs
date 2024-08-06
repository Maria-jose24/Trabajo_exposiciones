namespace Metodos
{
    class Program
    {
        static void Main()
        {
            // Crear una instancia de la clase MisterioNumerico
            MisterioNumerico misterio = new MisterioNumerico(28);

            // Mostrar información sobre el número
            misterio.MostrarInformacion();

            // Cambiar el número y mostrar información sobre el nuevo número
            misterio = new MisterioNumerico(123);
            misterio.MostrarInformacion();
        }
    }
}
