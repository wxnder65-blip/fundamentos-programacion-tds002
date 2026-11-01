
using System;

// Constante matematica PI
const double PI = Math.PI;

Console.WriteLine("========== CALCULADORA GEOMETRICA ==========");

// ENTRADA: solicitar radio y catetos
Console.Write("Ingrese el radio del circulo: ");
double radio = double.Parse(Console.ReadLine()!);

Console.Write("Ingrese el primer cateto: ");
double catetoA = double.Parse(Console.ReadLine()!);

Console.Write("Ingrese el segundo cateto: ");
double catetoB = double.Parse(Console.ReadLine()!);

// PROCESO: calcular area y circunferencia
double area = PI * Math.Pow(radio, 2);

double circunferencia = 2 * PI * radio;

// Calcular la hipotenusa mediante el teorema de Pitagoras
double hipotenusa = Math.Sqrt(
    Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2)
);

// SALIDA: mostrar resultados
Console.WriteLine("\n========== RESULTADOS ==========");

Console.WriteLine("--- CIRCULO ---");
Console.WriteLine($"Radio: {radio:N2}");
Console.WriteLine($"Area: {area:N2}");
Console.WriteLine($"Circunferencia: {circunferencia:N2}");

Console.WriteLine("\n--- TRIANGULO RECTANGULO ---");
Console.WriteLine($"Primer cateto: {catetoA:N2}");
Console.WriteLine($"Segundo cateto: {catetoB:N2}");
Console.WriteLine($"Hipotenusa: {hipotenusa:N2}");

Console.WriteLine("================================");
