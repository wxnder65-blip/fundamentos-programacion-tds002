
using System;

// Constante para convertir libras a kilogramos
const double LIBRAS_A_KILOGRAMOS = 0.453592;

Console.WriteLine("================================");
Console.WriteLine("       CONVERSOR DE UNIDADES");
Console.WriteLine("================================");

// Solicitar el peso en libras
Console.Write("Ingrese su peso en libras: ");
double libras = double.Parse(Console.ReadLine()!);

// Solicitar la temperatura en Fahrenheit
Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
double fahrenheit = double.Parse(Console.ReadLine()!);

// Conversion de libras a kilogramos
double kilogramos = libras * LIBRAS_A_KILOGRAMOS;

// Conversion de Fahrenheit a Celsius
double celsius = (fahrenheit - 32) * 5 / 9;

// Mostrar resultados
Console.WriteLine("\n========== RESULTADOS ==========");

Console.WriteLine($"Peso ingresado: {libras:F2} lb");
Console.WriteLine($"Peso convertido: {kilogramos:F2} kg");

Console.WriteLine($"Temperatura ingresada: {fahrenheit:F2} °F");
Console.WriteLine($"Temperatura convertida: {celsius:F2} °C");

Console.WriteLine("================================");
Console.WriteLine("Conversiones realizadas correctamente.");
