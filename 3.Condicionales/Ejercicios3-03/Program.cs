using System;

namespace Ejercicios3_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float importe, descuentoMenor, descuentoMayor, importeFinal;
            
            Console.WriteLine("Ingrese el importe de la compra.");
            importe = float.Parse(Console.ReadLine());

            if (importe >= 5000)
                importeFinal = importe * 0.82f;
            else if (importe >= 1000)
                importeFinal = importe * 0.9f;
            else
                importeFinal = importe;
            Console.WriteLine("El importe a cobrar es: $" + importeFinal.ToString("0.00") + ".");
        }
    }
}
