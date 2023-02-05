using System;

namespace Ejercicios3_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Ingrese cuatro números para averiguar cuáles son mayores a 100.");
            Console.WriteLine("Primer número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Tercer número:");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuarto número:");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > 100)
                Console.WriteLine(n1 + " es mayor a 100.");

            if (n2 > 100)
                Console.WriteLine(n2 + " es mayor a 100.");

            if (n3 > 100)
                Console.WriteLine(n3 + " es mayor a 100.");

            if (n4 > 100)
                Console.WriteLine(n4 + " es mayor a 100.");
        }
    }
}