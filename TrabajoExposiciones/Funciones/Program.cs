namespace Funciones
{
    class Program
    {
        static void Main()
        {
            // Crear una instancia de la clase CalculadoraSimple
            CalculadoraSimple calculadora = new CalculadoraSimple();

            // Realizar cálculos usando las funciones de la calculadora
            double num1 = 10.0;
            double num2 = 5.0;

            Console.WriteLine($"Suma: {calculadora.Sumar(num1, num2)}");
            Console.WriteLine($"Resta: {calculadora.Restar(num1, num2)}");
            Console.WriteLine($"Multiplicación: {calculadora.Multiplicar(num1, num2)}");
            Console.WriteLine($"División: {calculadora.Dividir(num1, num2)}");

            // Intentar dividir por cero
            Console.WriteLine($"División por cero: {calculadora.Dividir(num1, 0)}");
        }
    }
}