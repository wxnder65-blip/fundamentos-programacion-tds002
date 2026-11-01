
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Tasa de venta del dólar en pesos dominicanos
        const double TASA_USD = 60.5689;

        // Solicitar el monto en pesos
        Console.Write("Ingrese el monto en pesos dominicanos: RD$ ");
        double montoPesos = double.Parse(
            Console.ReadLine() ?? "0",
            CultureInfo.InvariantCulture);

        // Realizar la conversión
        double montoDolares = montoPesos / TASA_USD;

        // Mostrar los resultados
        Console.WriteLine("\n--- CONVERSOR DE MONEDA ---");
        Console.WriteLine($"Monto en pesos: RD$ {montoPesos:F2}");
        Console.WriteLine($"Tasa del dólar: RD$ {TASA_USD}");
        Console.WriteLine($"Equivalente en dólares: US$ {montoDolares:F2}");
    }
}
