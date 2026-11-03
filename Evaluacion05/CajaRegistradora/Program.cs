
Console.WriteLine("=== CAJA REGISTRADORA ===");

double precio;
double subtotal = 0;
int cantidadProductos = 0;

do
{
    Console.Write("Ingrese el precio del producto (0 para terminar): ");

    if (double.TryParse(Console.ReadLine(), out precio) && precio >= 0)
    {
        if (precio > 0)
        {
            subtotal += precio;
            cantidadProductos++;
        }
    }
    else
    {
        Console.WriteLine("Precio no válido. Intente nuevamente.");
        precio = -1;
    }

} while (precio != 0);

// Calcular ITBIS y total
double itbis = subtotal * 0.18;
double total = subtotal + itbis;

// Mostrar resumen de compra
Console.WriteLine("\n=== RESUMEN DE COMPRA ===");
Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: RD$ {subtotal:N2}");
Console.WriteLine($"ITBIS (18%): RD$ {itbis:N2}");
Console.WriteLine($"Total a pagar: RD$ {total:N2}");
