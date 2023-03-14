using System;

namespace Ejercicios7_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ventasArt = new int[15];
            int artActual, venta, maxVentas, c = 0, artMaxVentas = 0;

            for (int i = 0; i < 15; i++)
            {
                ventasArt[i] = 0;
            }

            do
            {
                Console.WriteLine("Ingrese el número de articulo (1 a 15)");
                artActual = int.Parse(Console.ReadLine());

                if (artActual != 0)
                {
                    Console.WriteLine("Cantidad vendida: ");
                    venta = int.Parse(Console.ReadLine());
                    ventasArt[artActual-1] = ventasArt[artActual-1] + venta;
                    Console.WriteLine("");
                    c++;
                }
            } while (artActual != 0);

            maxVentas = ventasArt[0];
            
            for (int i = 1; i < 15; i++)
            {
                if (ventasArt[i] > maxVentas)
                {
                    maxVentas = ventasArt[i];
                    artMaxVentas = i + 1;
                }
            }

            Console.WriteLine("El artículo que mas vendio fue el número " + artMaxVentas + ". Con " + maxVentas + " ventas.");
            Console.WriteLine("Artículos que no registraron ventas: ");
            for (int i = 0; i < 15; i++)
            {
                if (ventasArt[i] == 0)
                {
                    Console.WriteLine($"Artículo N°{i + 1}.");
                }
                
            }

            Console.WriteLine("El artículo N°10 vendió " + ventasArt[9] + ".");
        }
    }
}
