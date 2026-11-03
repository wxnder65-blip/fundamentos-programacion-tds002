
Console.WriteLine("=== ADIVINA EL NUMERO ===");

// Generar número secreto entre 1 y 100
int numeroSecreto = Random.Shared.Next(1, 101);

int intento;
int contador = 0;

do
{
    Console.Write("Adivina el número (1-100): ");

    if (!int.TryParse(Console.ReadLine(), out intento))
    {
        Console.WriteLine("Entrada no válida. Intente nuevamente.");
        continue;
    }

    contador++;

    if (intento < numeroSecreto)
    {
        Console.WriteLine("El número secreto es MAYOR.");
    }
    else if (intento > numeroSecreto)
    {
        Console.WriteLine("El número secreto es MENOR.");
    }

} while (intento != numeroSecreto);

// Mostrar resultado final
Console.WriteLine("\n¡Felicidades! Adivinaste el número.");
Console.WriteLine($"Número secreto: {numeroSecreto}");
Console.WriteLine($"Cantidad de intentos: {contador}");
