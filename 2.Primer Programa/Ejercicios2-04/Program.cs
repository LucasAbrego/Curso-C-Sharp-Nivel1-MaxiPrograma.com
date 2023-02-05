using System;

namespace Ejercicios2_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float const sueldo = 15000, porcentaje = 0.05f,
            float totalFacturado, sueldoTotal;
            
            Console.WriteLine("Ingrese el total facturado por el empleado: ");
            totalFacturado = float.Parse(Console.ReadLine());

            sueldoTotal = sueldo + totalFacturado * porcentaje;

            Console.WriteLine("El empleado cobrará: $" + sueldoTotal.ToString("0.00") + ".");
        }
    }
}
