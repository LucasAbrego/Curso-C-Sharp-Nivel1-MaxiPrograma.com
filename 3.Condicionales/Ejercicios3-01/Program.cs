using System;

namespace Ejercicios3_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            
            Console.WriteLine("Ingrese un número para evaluar si es mayor a 10 o no.");
            n = int.Parse(Console.ReadLine());

            if ( n < 10)
                Console.WriteLine("El número ingresado es menor a 10.");
            else if (n > 10)
                Console.WriteLine("El número ingresado es mayor a 10.");
            else
                Console.WriteLine("El número ingresado es 10.");
        }
    }
}
