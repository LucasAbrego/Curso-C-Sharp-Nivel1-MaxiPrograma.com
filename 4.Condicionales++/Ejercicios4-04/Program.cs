using System;

namespace Ejercicios4._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, operacion;

            Console.WriteLine("Ingrese tres números:");
            Console.WriteLine("Primer número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tercer número");
            n3 = int.Parse(Console.ReadLine());

            if (n1 + n2 > n2 * n3)
                Console.WriteLine($"La suma de {n1} y {n2} es mayor al producto de {n2} y {n3}");
        }
    }
}
