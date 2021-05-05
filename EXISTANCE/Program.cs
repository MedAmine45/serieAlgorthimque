using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXISTANCE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            do
            {
                Console.WriteLine("Donnez la taille du tableau T");
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
            }while(n<4||n>100);
            double[] tab = new double[n];
            for (int i = 0; i< n; i++)
            {
                Console.WriteLine($"Donnez la valeur de l'élément N° {i+1}");
                Console.Write("tab[" + i + "] = ");
                tab[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} || ");
                
            }
            Console.WriteLine("\n");    
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Tapez la valeur recherchée");
            Console.Write("n = ");
            double r = double.Parse(Console.ReadLine());
            int occ = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if( tab[i] == r)
                {
                    occ++;
                }
            }

            Console.WriteLine($"{r} existe {occ} fois dans T"); 
            Console.ReadKey();
        }
    }
}
