
using System;

class Program
{
    static void Main(string[] args)
    {
        // Constante con el año actual
        const int ANIO_ACTUAL = 2026;

        // Solicitar el nombre
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine() ?? "";

        // Solicitar la edad
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine() ?? "0");

        // Solicitar la estatura
        Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
        double estatura = double.Parse(Console.ReadLine() ?? "0");

        // Calcular el año de nacimiento
        int anioNacimiento = ANIO_ACTUAL - edad;

        // Mostrar los resultados utilizando interpolación
        Console.WriteLine("\n--- DATOS DEL USUARIO ---");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} metros");
        Console.WriteLine($"Año de nacimiento: {anioNacimiento}");
    }
}
