using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXISTANCESSTRING
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
            } while (n < 3 || n > 199);
            return n;
        }
        public static int lire_p()
        {
            int n;
            do
            {
                Console.WriteLine("Donnez le nombre des mots");
                Console.Write("p =");
                n = int.Parse(Console.ReadLine());
            } while (n < 3 || n > 19);
            return n;
        }

        public static char[] remplir_T(int n)
        {
            char[] Tab = new char[n];
            for(int i= 0; i < n; i++)
            {
                Console.WriteLine($"Tapez le caractère N°{i + 1}");
                Tab[i] = char.Parse(Console.ReadLine());
            }
            return Tab;
        }
        public static void afficher_T(char[] tab)
        {
            for(int i = 0 ; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        }

        public static string[] remplir_TM(int n)
        {
            string[] Tab = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Donnez le mot N°{i + 1}");
                Tab[i] = Console.ReadLine();
            }
            return Tab;
        }
        public static void afficher_TM(string[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        }

        public static bool verifier(string ch,char[] T)
        {
                if (ch.All(x => T.Contains(x)))
            {
                return true;
            }
            else
            {
                return false;
            }

              
        }
        static void Main(string[] args)
        {
            int n = lire_n();
            char[] T = new char[n];
            T = remplir_T( n);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            afficher_T(T);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            int p = lire_p();
            string[] Tm = new string[p];
            Tm = remplir_TM(p);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            afficher_TM(Tm);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            for(int i = 0; i < p; i++)
            {
                if (verifier(Tm[i], T))
                {
                    Console.WriteLine($"{Tm[i]} existe dans le tableau de caracteres");
                }
                else
                {
                    Console.WriteLine($"{Tm[i]} n'existe pas dans le tableau de caracteres");
                }
            }
            Console.ReadKey();
        }
    }
}
