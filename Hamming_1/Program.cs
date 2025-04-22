using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamming_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ADN1 = "";
            string ADN2 = "";
            Console.WriteLine("Ingrese primer cadena");
            ADN1 =  Console.ReadLine();
            Console.WriteLine("Ingrese segunda cadena");
            ADN2 = Console.ReadLine();
            int distancia = 0;
            if (ADN1.Length == ADN2.Length && ADN1.Length > 0 && ADN2.Length > 0)
            {
                for (int i = 0; i <= ADN1.Length; i++)
                {
                    if (ADN1.Substring(i) == ADN2.Substring(i))
                    {
                        distancia++;
                    }        
                }
            }
            Console.WriteLine($"Distancia: {distancia}");
        }
    }
}
