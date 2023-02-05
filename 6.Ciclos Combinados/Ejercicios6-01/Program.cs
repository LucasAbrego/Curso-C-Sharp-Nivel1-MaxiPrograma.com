using System;

namespace Ejercicios6_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cprimo = 0, cresto;

            Console.WriteLine("Igrese 10 números para averiguar cuántos son primos.");

            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(Console.ReadLine());
                cresto = 0;

                for (int j = 1; j <= n; j++)
                {
                    if (n % j == 0)
                        cresto++;
                }
                if (cresto == 2 || n == 1)
                    cprimo++;
            }

            Console.WriteLine($"Se ingresaron {cprimo} números primos.");
        }
    }
}
