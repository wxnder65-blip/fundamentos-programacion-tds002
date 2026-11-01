
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar el nombre
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine() ?? "";

        // Solicitar la edad
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine() ?? "0");

        // Solicitar la estatura
        Console.Write("Ingrese su estatura en metros: ");
        double estatura = double.Parse(
            Console.ReadLine() ?? "0",
            CultureInfo.InvariantCulture);

        // Solicitar si trabaja
        Console.Write("¿Actualmente trabaja? (true/false): ");
        bool trabaja = bool.Parse(Console.ReadLine() ?? "false");

        // Calcular el año en que cumplirá 30 años
        const int ANIO_ACTUAL = 2026;
        int anioCumple30 = ANIO_ACTUAL + (30 - edad);

        // Mostrar la ficha personal
        Console.WriteLine("\n--- FICHA PERSONAL ---");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} metros");
        Console.WriteLine($"¿Trabaja?: {trabaja}");
        Console.WriteLine($"Año en que cumplirá 30 años: {anioCumple30}");
    }
}
