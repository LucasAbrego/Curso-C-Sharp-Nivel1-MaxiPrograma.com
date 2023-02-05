using System;

namespace Ejercicios4_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Ingrese cuatro números para averiguar si estan ordenados de forma decreciente.");
            Console.WriteLine("Primer número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tercer número");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuarto número");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n2 > n3 && n3 > n4)
                Console.WriteLine("Los números estan ordenados de forma decreciente.");
            else
                Console.WriteLine("Los números no estan ordenados de forma decreciente.");
        }

    }
}