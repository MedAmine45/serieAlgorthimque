using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIERINT
{
    class Program
    {
        public static int lire_n()
        {
            int n;
            do
            {
                Console.WriteLine("Donnez la taille du tableau T");
                Console.Write("n =");
                n = int.Parse(Console.ReadLine());
            } while (n < 6 || n > 24);
            return n;
        }
        public static int[] remplir_T(int n)
        {
            int[] Tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine($"Donnez la valeur de l'élément N°{ i + 1}");
                    Tab[i] = int.Parse(Console.ReadLine());
                } while (Tab[i]<=0);

            }
            return Tab;
        }
        public static void afficher_T(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        }
        private static int maximum(int[] t1)
        {
            int ind = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                    if ( t1[ind] < t1[i])
                    {
                        ind = i;
                    }
                
            }
            return ind;
        }
        static void Main(string[] args)
        {
            int n = lire_n();
            int[] tab = new int[n];
            tab = remplir_T(n);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            afficher_T(tab);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            int max;
            int[] T2 = new int[n];
            for (int i = 0; i < tab.Length; i++)
            {
                max = maximum(tab);
                T2[i] = tab[max];
                tab[max] = -1;
            }
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            afficher_T(T2);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            afficher_T(tab);
            Console.ReadKey();

        }
    }
}
