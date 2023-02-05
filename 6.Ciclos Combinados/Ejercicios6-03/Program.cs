using System;

namespace Ejercicios6_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1, cN = 0, cG = 0;

            Console.WriteLine("Ingrese las listas separadas por 0. Para finalizar ingrese un número negativo.");

            do
            {
                cG++;
                cN = 0;
                n = int.Parse(Console.ReadLine());
                while (n != 0)
                {
                    cN++;
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"El grupo {cG} posee {cN} números.");
            } while (n >= 0);
        }
    }
}
