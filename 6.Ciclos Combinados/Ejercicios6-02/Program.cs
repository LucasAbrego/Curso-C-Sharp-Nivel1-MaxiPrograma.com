using System;

namespace Ejercicios6_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gruposOrdenados = 0;
            float grupoMaxProImp = 0, maxProImp = 0;
            Console.WriteLine("Ingrese las listas de números separadas por 0.");

            for (int i = 0; i < 5; i++)
            {
                int n = 0, nAnt = 0;
                bool ban = true, orden = true;
                float cImpar = 0, cNum = 0, proImp = 0;

                Console.WriteLine("Lista " + (i+1) + ".");

                while (n != 0 || ban == true)
                {
                    n = int.Parse(Console.ReadLine());
                    
                    if (n != 0)
                    {
                        cNum++;

                        if (n % 2 != 0)
                            cImpar++;

                        if (ban == true)
                        {
                            ban = false;
                            nAnt = n;
                        }
                        else
                        {
                            if (nAnt <= n)
                            {
                                orden = false;
                            }
                            else
                            {
                                nAnt = n;
                            }
                        }
                    }
                }
                
                if (orden == true)
                    gruposOrdenados++;

                proImp = cImpar / cNum * 100;

                if (maxProImp == 0)
                {
                    maxProImp = proImp;
                    grupoMaxProImp = i + 1;
                }
                    
                else
                {
                    if (proImp > maxProImp)
                    {
                        maxProImp = proImp;
                        grupoMaxProImp = i + 1;
                    }
                }
                
            }
            if (gruposOrdenados == 0)
                Console.WriteLine("No se ingresaron grupos ordenados decrecientemente.");
            else
                Console.WriteLine($"Se ingresaron {gruposOrdenados} grupos ordenados decrecientemente.");
            
            if (grupoMaxProImp == 0)
                Console.WriteLine("No se ingresaron número impares.");
            else
                Console.WriteLine($"El grupo con mayor porcentaje de números impares es el Grupo {grupoMaxProImp} con un porcentaje de {maxProImp.ToString("0.00")}");
            
        }
    }
}
