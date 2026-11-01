
using System;

// Constantes de deducciones salariales
const double PORCENTAJE_AFP = 0.0287;
const double PORCENTAJE_SFS = 0.0304;

Console.WriteLine("========== CALCULO DE NOMINA ==========");

// ENTRADA: solicitar datos del empleado
Console.Write("Ingrese el nombre del empleado: ");
string nombre = Console.ReadLine()!;

Console.Write("Ingrese las horas trabajadas: ");
double horasTrabajadas = double.Parse(Console.ReadLine()!);

Console.Write("Ingrese el pago por hora (RD$): ");
double pagoPorHora = double.Parse(Console.ReadLine()!);

// PROCESO: calcular salario y deducciones
double salarioBruto = horasTrabajadas * pagoPorHora;

double afp = salarioBruto * PORCENTAJE_AFP;
double sfs = salarioBruto * PORCENTAJE_SFS;

double salarioNeto = salarioBruto - afp - sfs;

// SALIDA: mostrar resultados
Console.WriteLine("\n========== RESUMEN DE NOMINA ==========");

Console.WriteLine($"Empleado: {nombre.ToUpper()}");
Console.WriteLine($"Horas trabajadas: {horasTrabajadas:N2}");
Console.WriteLine($"Pago por hora: RD$ {pagoPorHora:N2}");

Console.WriteLine("---------------------------------------");
Console.WriteLine($"Salario bruto: RD$ {salarioBruto:N2}");
Console.WriteLine($"AFP (2.87%): RD$ {afp:N2}");
Console.WriteLine($"SFS (3.04%): RD$ {sfs:N2}");
Console.WriteLine("---------------------------------------");
Console.WriteLine($"SALARIO NETO: RD$ {salarioNeto:N2}");
Console.WriteLine("=======================================");
