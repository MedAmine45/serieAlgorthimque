using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FACTEURS_PREMIERS
{
    class Program
    {
        public static int lire()
        {
            int x;
            do
            {
                Console.WriteLine("Donnez un entier compris entre 2 et 100");
                Console.Write(" n = ");
                x = int.Parse(Console.ReadLine());
            }
            while (x < 2 || x > 300);
            return x;
        }
        public static void decomposer(int x,List<int> produits)
        {
            int r, q, d;
            d = 2;
            do
            {
                r = x % d;
                q = x / d;
                if (r == 0)
                {
                  
                    produits.Add(d);
                    x = q;
                }
                else
                {
                    d++;
                }

            } while (x != 1);
        }
        public static void afficher(int n, List<int> produits)
        {
            Console.Write($"{n} = ");
            if(produits.Count!= 1)
            {
                string  resutlt = produits.Select(x => x.ToString()).Aggregate((a, b) => a + " * " + b);
                Console.Write(resutlt);
            
            }
            else
            {
                Console.WriteLine(produits.FirstOrDefault());
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int n;
            List<int> produits = new List<int>();

            n= lire();
            decomposer(n, produits);
           
            afficher(n ,produits);
            Console.ReadKey();
        }
    }
}
