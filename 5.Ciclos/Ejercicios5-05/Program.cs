using System;

namespace Ejercicios5_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, maxP = 0, minI = 0, bP = 0, bI = 0;

            Console.WriteLine("Ingrese 20 números:");
            for (int i = 0; i < 20; i++)
            {
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    if (bP == 0)
                    {
                        bP = 1;
                        maxP = n;
                    }
                    else
                        if (n > maxP)
                    {
                        maxP = n;
                    }
                }
                else
                {
                    if (bI == 0)
                    {
                        bI = 1;
                        minI = n;
                    }
                    else
                        if (n < minI)
                    {
                        minI = n;
                    }
                }
            }
            if (bP != 0)
                Console.WriteLine($"El mayor número par ingresado fue el {maxP}.");
            else
                Console.WriteLine("No se ingresó ningún número par.");
            if (bI != 0)
                Console.WriteLine($"El menor número impar ingresado fue el {minI}.");
            else
                Console.WriteLine("No se ingreso ningún número impar.");
        }
    }
}
