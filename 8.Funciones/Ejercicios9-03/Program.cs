using System;

namespace Ejercicios9_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1, primo, acu = 0, c = 0, promedio = 0;

            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());
                primo = f_primo(n);
                if (primo == 1)
                {
                    acu += n;
                    c++;
                }
            }
            promedio = acu / c;
            if (promedio == 0)
                Console.WriteLine("No se ingresaron números primos.");
            else
                Console.WriteLine("El promedio de los números primos ingresados es " + promedio + ".");
        }
        static int f_primo(int n)
        {
            int cResto = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                cResto++;
            if (cResto == 2 || n == 1)
                return 1;
            else
                return 0;
        }
    }
}
