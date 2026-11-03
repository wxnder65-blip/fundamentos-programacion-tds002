
Console.WriteLine("=== PROMEDIO DE CALIFICACIONES ===");

int nota;
int cantidadNotas = 0;
int suma = 0;

int notaMayor = 0;
int notaMenor = 100;

do
{
    bool entradaValida;

    // Validar la nota o aceptar -1 para terminar
    do
    {
        Console.Write("Ingrese una nota (0-100) o -1 para terminar: ");

        entradaValida = int.TryParse(Console.ReadLine(), out nota)
                        && (nota == -1 || (nota >= 0 && nota <= 100));

        if (!entradaValida)
        {
            Console.WriteLine("Nota no válida. Ingrese un valor entre 0 y 100.");
        }

    } while (!entradaValida);

    // Procesar la nota si no es el valor de salida
    if (nota != -1)
    {
        suma += nota;
        cantidadNotas++;

        if (nota > notaMayor)
        {
            notaMayor = nota;
        }

        if (nota < notaMenor)
        {
            notaMenor = nota;
        }
    }

} while (nota != -1);

// Mostrar resultados
Console.WriteLine("\n=== RESULTADOS ===");

if (cantidadNotas > 0)
{
    double promedio = (double)suma / cantidadNotas;

    Console.WriteLine($"Cantidad de notas: {cantidadNotas}");
    Console.WriteLine($"Promedio: {promedio:N2}");
    Console.WriteLine($"Nota mayor: {notaMayor}");
    Console.WriteLine($"Nota menor: {notaMenor}");
}
else
{
    Console.WriteLine("No se ingresaron calificaciones.");
}

