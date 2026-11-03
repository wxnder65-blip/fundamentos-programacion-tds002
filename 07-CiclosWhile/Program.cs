
Console.WriteLine("=== TABLA DE MULTIPLICAR ===");

// 1. Validar el número con do-while
int numero;
bool valido;

do
{
    Console.Write("Ingrese un número entre 1 y 12: ");
    string entrada = Console.ReadLine()!;

    valido = int.TryParse(entrada, out numero) 
             && numero >= 1 
             && numero <= 12;

    if (!valido)
    {
        Console.WriteLine("Número no válido. Intente nuevamente.");
    }

} while (!valido);

// 2. Mostrar la tabla con while
int contador = 1;
int suma = 0;

Console.WriteLine($"\nTabla de multiplicar del {numero}:");

while (contador <= 12)
{
    int resultado = numero * contador;

    Console.WriteLine($"{numero} x {contador} = {resultado}");

    // 3. Acumulador
    suma = suma + resultado;

    contador++;
}

// Mostrar la suma total
Console.WriteLine("\n-------------------------");
Console.WriteLine($"La suma de los resultados es: {suma}");
