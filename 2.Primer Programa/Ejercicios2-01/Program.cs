using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicios2_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese dos números");
            Console.WriteLine("Primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine("La suma de ambos números es: " + resultado + ".");
        }
    }
}
