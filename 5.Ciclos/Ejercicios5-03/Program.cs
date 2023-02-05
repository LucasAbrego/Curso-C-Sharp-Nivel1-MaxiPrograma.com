using System;

namespace Ejercicios5_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float c = 0, acu = 0, n, promedio;
            
            Console.WriteLine("Ingrese las edades de los participantes. Calcularemos el promedio de los mayores de 18 años.");

            for (int i = 0; i < 20; i++)
            {
                n = float.Parse(Console.ReadLine());

                if (n > 18)
                {
                    c++;
                    acu += n;
                }
            }

            promedio = acu / c;

            Console.WriteLine("El promedio de los mayores de 18 años es: " + promedio.ToString("0.00") + ".");
        }
    }
}
