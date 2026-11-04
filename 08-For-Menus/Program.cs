
using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Mostrar tablas de multiplicar");
            Console.WriteLine("2. Dibujar triangulo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opcion: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n=== TABLAS DEL 1 AL 10 ===");

                    Console.Write("    ");

                    for (int columna = 1; columna <= 10; columna++)
                    {
                        Console.Write($"{columna,4}");
                    }

                    Console.WriteLine();

                    for (int fila = 1; fila <= 10; fila++)
                    {
                        Console.Write($"{fila,4}");

                        for (int columna = 1; columna <= 10; columna++)
                        {
                            int resultado = fila * columna;
                            Console.Write($"{resultado,4}");
                        }

                        Console.WriteLine();
                    }
                    break;

                case 2:
                    Console.Write("\nIngrese la cantidad de filas: ");

                    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= n - i; j++)
                            {
                                Console.Write(" ");
                            }

                            for (int k = 1; k <= (2 * i - 1); k++)
                            {
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un numero entero positivo.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida. Intente nuevamente.");
                    break;
            }

        } while (opcion != 0);
    }
}
