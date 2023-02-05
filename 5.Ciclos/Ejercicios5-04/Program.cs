using System;

namespace Ejercicios05_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cp = 0, n;

            Console.WriteLine("Ingrese un número para determinar si es primo o no.");
            n = int.Parse(Console.ReadLine());

            int i = 0;

            while (i < n)
            {
                i++;

                if (n % i == 0)
                    cp++;
            }

            if (cp == 2 || n == 1)
                Console.WriteLine(n + " es un número primo.");
            else
                Console.WriteLine(n + " no es un número primo.");
        }
    }
}
