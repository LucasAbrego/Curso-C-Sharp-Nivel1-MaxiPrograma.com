using System;

namespace Ejercicios2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, cubo;

            Console.WriteLine("Ingrese un número para elevarlo al cubo.");
            n1 = int.Parse(Console.ReadLine());

            cubo = n1 * n1 * n1;

            Console.WriteLine("El número ingresado elevado al cubo da como resultado: " + cubo + ".");
        }
    }
}
