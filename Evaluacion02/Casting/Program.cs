
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar un número decimal
        Console.Write("Ingrese un número con decimales: ");
        double numeroDecimal = double.Parse(
            Console.ReadLine() ?? "0",
            CultureInfo.InvariantCulture);

        // Casting explícito: double a int
        int parteEntera = (int)numeroDecimal;

        // Declarar un número entero
        int numeroEntero = 25;

        // Casting implícito: int a double
        double numeroConvertido = numeroEntero;

        // Mostrar los resultados
        Console.WriteLine("\n--- DEMOSTRACIÓN DE CASTING ---");
        Console.WriteLine($"Número decimal original: {numeroDecimal}");
        Console.WriteLine($"Parte entera (casting explícito): {parteEntera}");
        Console.WriteLine($"Número entero original: {numeroEntero}");
        Console.WriteLine($"Conversión implícita a double: {numeroConvertido}");
    }
}
