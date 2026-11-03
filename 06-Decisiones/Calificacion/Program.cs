
Console.WriteLine("=== SISTEMA DE CALIFICACIONES ===");

Console.Write("Ingrese la nota del estudiante (0-100): ");
string entrada = Console.ReadLine()!;

// Validar que la entrada sea un número entero
if (int.TryParse(entrada, out int nota))
{
    // Validar que la nota esté dentro del rango permitido
    if (nota >= 0 && nota <= 100)
    {
        if (nota >= 90)
        {
            Console.WriteLine("Calificación: A");
        }
        else if (nota >= 80)
        {
            Console.WriteLine("Calificación: B");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Calificación: C");
        }
        else
        {
            Console.WriteLine("Calificación: F");
        }
    }
    else
    {
        Console.WriteLine("Error: La nota debe estar entre 0 y 100.");
    }
}
else
{
    Console.WriteLine("Error: Debe ingresar un número entero válido.");
}
