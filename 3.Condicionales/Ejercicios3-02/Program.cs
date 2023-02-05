using System;

namespace Ejercicios3_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Ingrese un número para evaluar si es positivo, negativo o 0.");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
                Console.WriteLine("El número ingresado es negativo.");
            else if (n > 0)   
                Console.WriteLine("El número ingresado es positivo.");
            else
                Console.WriteLine("El número ingresado es 0.");
        }
    }
}
