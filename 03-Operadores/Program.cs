
using System;

Console.WriteLine("=== PROGRAMA DE OPERADORES ===");

// Leer los dos números enteros
Console.Write("Ingrese el primer numero: ");
int numero1 = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el segundo numero: ");
int numero2 = int.Parse(Console.ReadLine()!);

// Operaciones matematicas
Console.WriteLine("\n=== RESULTADOS ===");

Console.WriteLine($"Suma: {numero1 + numero2}");
Console.WriteLine($"Resta: {numero1 - numero2}");
Console.WriteLine($"Producto: {numero1 * numero2}");

// Verificar que el segundo numero no sea cero
if (numero2 != 0)
{
    Console.WriteLine($"Division real: {(double)numero1 / numero2}");
    Console.WriteLine($"Division entera: {numero1 / numero2}");
    Console.WriteLine($"Residuo: {numero1 % numero2}");
}
else
{
    Console.WriteLine("No se puede dividir entre cero.");
}

// Comprobar si el primer numero es par
bool esPar = numero1 % 2 == 0;
Console.WriteLine($"El primer numero es par: {esPar}");

/*
PRUEBA DE ESCRITORIO
Valores:
x = 10
y = 3

Operacion          Resultado
--------------------------------
Suma:              10 + 3 = 13
Resta:             10 - 3 = 7
Producto:          10 * 3 = 30
Division real:     10 / 3 = 3.333333...
Division entera:   10 / 3 = 3
Residuo:           10 % 3 = 1
Es par:            10 % 2 == 0 = true

FIN DE LA PRUEBA DE ESCRITORIO
*/
