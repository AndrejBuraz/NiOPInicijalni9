using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj clanova niza: ");
            int n = Convert.ToInt32(Console.ReadLine()), i, j, priv;
            int[] niz = new int[n];
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Unesi " + (i + 1) + ". član: ");
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < (n-1) ; j++)
                {
                    if (niz[j + 1] < niz[j])
                    {
                        priv = niz[j];
                        niz[j] = niz[j + 1];
                        niz[j + 1] = priv;
                    }
                }
            }
            Console.WriteLine("Sortirani niz: ");
            for(i = 0; i < n; i++)
            {
                Console.Write(niz[i]);
                Console.Write(", ");
            }
            Console.ReadKey();
            
        }
    }
}
