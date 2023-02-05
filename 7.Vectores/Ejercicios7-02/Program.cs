using System;

namespace Ejercicios7_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int promedio, acuNum = 0;

            Console.WriteLine("Ingrese 10 números para calcular el promedio.");
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Calculado promedio...");
            for (int i = 0; i < 10; i++)
            {
                acuNum += numeros[i];
            }
            promedio = acuNum / 10;

            Console.WriteLine("Números mayores al promedio (" + promedio + ").");
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > promedio)
                    Console.WriteLine(numeros[i]);
            }
        }
    }
}
