using System;

namespace Ejercicios9_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, res = 2;
            Console.WriteLine("Ingrese un número:");
            num = int.Parse(Console.ReadLine());

            f_positivoNegativoCero(num, ref res);

            switch (res)
            {
                case -1:
                    Console.WriteLine("Negativo");
                    break;
                case 0:
                    Console.WriteLine("Cero");
                    break;
                case 1:
                    Console.WriteLine("Positivo");
                    break;
            }
        }

        static void f_positivoNegativoCero (int n, ref int resultado)
        {
            if (n > 0)
                resultado = 1;
            else if (n < 0)
                resultado = -1;
            else
                resultado = 0;
        }
    }
}
