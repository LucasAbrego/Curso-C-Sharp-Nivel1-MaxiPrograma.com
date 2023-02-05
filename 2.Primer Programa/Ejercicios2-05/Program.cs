using System;

namespace Ejercicios2_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promedio, n1, n2, n3;

            Console.WriteLine("Ingrese las notas para calcular el primedio.");
            Console.WriteLine("Nota 1:");
            n1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Nota 2:");
            n2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Nota 3:");
            n3 = double.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3 ) / 3;

            Console.WriteLine("El promedio de las notas ingresadas es: " + promedio.ToString("0.00") + ".");
        }
    }
}
