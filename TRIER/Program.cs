using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIER
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
            } while (n < 5 || n > 20);
            return n;
        }
        public static char[] remplir_T(int n)
        {
            char[] Tab = new char[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine($"Tapez le caractère N°{i + 1}");
                    Tab[i] = char.Parse(Console.ReadLine());
                } while (!char.IsUpper(Tab[i]));
               
            }
            return Tab;
        }
        public static void afficher_T(char[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        }
        static void Main(string[] args)
        {
            int n = lire_n();
            char[] T1 = new char[n];
            T1 = remplir_T(n);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            afficher_T(T1);
            int min;
            char[] T2 = new char[n];
            for (int i= 0; i < T1.Length; i++)
            {
                min = chercher(T1, n);
                T2[i] = T1[min];
                T1[min] = '*';
            }

            Console.WriteLine("\n");
            Console.WriteLine("----------------------");  
            afficher_T(T2);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            afficher_T(T1);
            Console.ReadKey();
        }

        private static int chercher(char[] t1, int n)
        {
            int ind = 0;
            for(int i = 0; i < t1.Length; i++)
            {
                if(t1[i] != '*')
                {
                    if(t1[ind]=='*' || t1[ind] > t1[i])
                    {
                        ind = i;
                    }
                }
            }
            return ind;
        }
    }
}
