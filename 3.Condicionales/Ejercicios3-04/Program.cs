using System;

namespace Ejercicios3_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, menor;

            Console.WriteLine("Ingrese cuatro números para averiguar el menor de ellos.");
            Console.WriteLine("Primer número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Tercer número:");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuarto número:");
            n4 = int.Parse(Console.ReadLine());

            if (n1 < n2)
                menor = n1;
            else
                menor = n2;

            if (n3 < menor) 
                menor = n3; 

            if (n4 < menor)
                menor = n4;

            Console.WriteLine("El menor número ingresado es " + menor + ".");
        }
    }
}
