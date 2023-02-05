using System;

namespace Ejercicios4_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cpu, ram, memEx = 0, importe = 0;

            Console.WriteLine("Armemos tu PC!");
            Console.WriteLine("Elige un procesador:");
            Console.WriteLine("|  1. i5 |  2. i7  |  3. i9  |");
            cpu = int.Parse(Console.ReadLine());
            Console.WriteLine("Elige la cantidad de memoria RAM:");
            Console.WriteLine("|  1. 8RAM  |  2. 16RAM  |  3. 32RAM  |");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Ampliación de almacenamiento a 1TB:");
            Console.WriteLine("|  1. SI  |  2. NO  |");
            memEx = int.Parse(Console.ReadLine());

            switch (cpu) 
            {
                case 1: switch (ram)
                    {
                        case 1:
                            importe = 800; 
                            break;
                        case 2:
                            importe = 900;
                            break;
                        case 3:
                            importe = 1000;
                            break;
                    }
                    break;
                case 2:
                    switch (ram)
                    {
                        case 1:
                            importe = 900;
                            break;
                        case 2:
                            importe = 1000;
                            break;
                        case 3:
                            importe = 1400;
                            break;
                    }
                    break;
                case 3:
                    switch (ram)
                    {
                        case 1:
                            importe = 1200;
                            break;
                        case 2:
                            importe = 1400;
                            break;
                        case 3:
                            importe = 2000;
                            break;
                    }
                    break;
            }

            if (memEx == 1)
            {
                importe += 300;
            }

            Console.WriteLine("El importe total es de " + importe + "USD.");
        }
    }
}
