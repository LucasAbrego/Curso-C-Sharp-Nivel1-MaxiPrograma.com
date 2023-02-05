using System;

namespace Ejercicios4_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float importe, litros, importeFinal;

            Console.WriteLine("Ingrese el importe total de la venta: ");
            importe = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
            litros = float.Parse(Console.ReadLine());

            if (litros > 500)
                importeFinal = importe * 0.75f;
            else
            {
                if (litros > 300)
                    importeFinal = importe * 0.85f;
                else
                {
                    if (litros > 100)
                        importeFinal = importe * 0.9f;
                    else
                        importeFinal = importe;
                }
            }

            Console.WriteLine("El importe a cobrar es: $" + importeFinal + ".");
        }
    }
}
