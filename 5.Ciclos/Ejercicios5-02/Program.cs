using System;

namespace Ejercicios5_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, mayor;

            Console.WriteLine("Ingrese 10 números para averiguar el mayor.");

            n = int.Parse(Console.ReadLine());
            mayor = n;

            for (int i = 0; i < 9; i++)
            {
                n = int.Parse(Console.ReadLine());

                if (n > mayor)
                    mayor = n;
            }

            Console.WriteLine("El mayor número ingresado fue el: " + mayor + ".");
        }
    }
}
