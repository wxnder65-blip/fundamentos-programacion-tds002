
using System;

// Constante para el calculo del ITBIS
const double PORCENTAJE_ITBIS = 0.18;

Console.WriteLine("============== FACTURA ==============");

// ENTRADA: solicitar datos del producto
Console.Write("Ingrese el nombre del producto: ");
string producto = Console.ReadLine()!;

Console.Write("Ingrese la cantidad: ");
int cantidad = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el precio unitario (RD$): ");
double precio = double.Parse(Console.ReadLine()!);

// PROCESO: calcular subtotal, ITBIS y total
double subtotal = cantidad * precio;
double itbis = subtotal * PORCENTAJE_ITBIS;
double total = subtotal + itbis;

// SALIDA: presentar factura en columnas
Console.WriteLine("\n============== DETALLE ==============");

Console.WriteLine("Producto".PadRight(20) + "Cantidad".PadLeft(10));
Console.WriteLine("-------------------------------------");

Console.WriteLine(producto.PadRight(20) + cantidad.ToString().PadLeft(10));

Console.WriteLine("-------------------------------------");
Console.WriteLine($"{"Subtotal:",-20}{subtotal,17:N2}");
Console.WriteLine($"{"ITBIS (18%):",-20}{itbis,17:N2}");
Console.WriteLine("-------------------------------------");
Console.WriteLine($"{"TOTAL:",-20}{total,17:N2}");

Console.WriteLine("=====================================");
