using System;

namespace Ejercicios2_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia, velocidad, tiempo;

            Console.WriteLine("Ingrese la distancia existente entre dos ciudades y la velocidad promedio para calcular el tiempo estimado.");
            Console.WriteLine("Distancia en Km: ");
            distancia = int.Parse(Console.ReadLine());

            Console.WriteLine("Velocidad promedio en Km/h: ");
            velocidad = int.Parse(Console.ReadLine());

            tiempo = distancia / velocidad * 60;

            Console.WriteLine("El tiempo de viaje aproximado es de " + tiempo + " minutos.");
        }
    }
}
