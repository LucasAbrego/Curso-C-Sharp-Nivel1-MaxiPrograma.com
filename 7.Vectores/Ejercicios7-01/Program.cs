using System;

namespace Ejercicios7_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
        
            Console.WriteLine("Ingrese 10 números para encontrar el mayor.");
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int iMax = 1, maximo = numeros[0];

            for (int i = 1; i < 10; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                    iMax = i + 1;
                }
            }
            Console.WriteLine("El mayor número ingresado fue el "+ maximo + " en la posición " + iMax + ".");
        }
    }
}
