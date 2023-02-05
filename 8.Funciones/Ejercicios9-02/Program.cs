using System;

namespace Ejercicios9_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            int cPar = 0;
            
            Console.WriteLine("Ingrese 20 números.");
            for (int i = 0; i < 20; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
                if (f_par(numeros[i]) == 1)
                {
                    cPar++;
                }                    
            }
            Console.WriteLine("Se ingresaron " + cPar + " números pares.");
        }

        static int f_par(int n)
        {
            if (n % 2 == 0)
                return 1;
            else 
                return 0;
        }
    }
}
