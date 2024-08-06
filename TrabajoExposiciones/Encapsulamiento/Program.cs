namespace Encapsulamiento
{
    class Program
    {
        static void Main()
        {
            // Crear un nuevo perfil de usuario
            PerfilUsuario usuario = new PerfilUsuario("Carlos Cadena", 35);

            // Mostrar información del usuario
            usuario.MostrarInformacion();

            // Actualizar el nombre del usuario
            usuario.Nombre = "Juan Corredor";

            // Mostrar la información actualizada del usuario
            usuario.MostrarInformacion();
        }
    }
}
