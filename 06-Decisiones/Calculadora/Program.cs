
Console.WriteLine("=== CALCULADORA ===");

Console.Write("Ingrese el primer número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nSeleccione una operación:");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");

Console.Write("Opción: ");
int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine($"Resultado: {numero1 + numero2}");
        break;

    case 2:
        Console.WriteLine($"Resultado: {numero1 - numero2}");
        break;

    case 3:
        Console.WriteLine($"Resultado: {numero1 * numero2}");
        break;

    case 4:
        if (numero2 != 0)
        {
            Console.WriteLine($"Resultado: {numero1 / numero2}");
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
        break;

    default:
        Console.WriteLine("Opción no válida.");
        break;
}
