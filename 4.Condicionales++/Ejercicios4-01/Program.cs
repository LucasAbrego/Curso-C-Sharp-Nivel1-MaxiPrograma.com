using System;

namespace Ejercicios4_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, operacion;
            
            Console.WriteLine("Ingrese dos números: ");
            Console.WriteLine("Primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
                operacion = n1 - n2;
            else if (n1 == n2)
                operacion = n1 + n2;
            else
                operacion = n1 * n2;

            Console.WriteLine("El resultado es:" + operacion + ".");
        }
    }
}
