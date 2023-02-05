using System;

namespace Ejercicios9_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int precio, cantidad, producto;
            Console.WriteLine("Precio del artículo: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());
            producto = f_producto(precio, cantidad);

            Console.WriteLine("El resultado es: " + producto +".");
        }

        static int f_producto(int a, int b)
        {
            return a * b;
        }
    }
}
