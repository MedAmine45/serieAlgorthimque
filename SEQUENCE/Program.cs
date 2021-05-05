using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SEQUENCE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = lire();
            int[] tab = remplir(n);
            Console.WriteLine("-----------------------");

            Console.WriteLine("\n le tableau \n");

            affiche(tab);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------");
            
            int x = lire_entier(1, n);
            Console.WriteLine("-----------------------");
            int  y = lire_entier(x, n);
            Console.WriteLine("-----------------------");
            int v_max = maximum(tab, x, y);
            int v_min = minmum(tab, x, y);
            Console.WriteLine($"La valeur maximal dans l'intervalle [{x},{y}] = {v_max}");
            Console.WriteLine($"La valeur minimal dans l'intervalle [{x},{y}] = {v_min}");


            Console.ReadKey();

        }
        public static int lire_entier(int x,  int y)
        {
            int n;
            do
            {
                Console.WriteLine($"Donnez un entier compris entre {x} et {y}");
             
                n = int.Parse(Console.ReadLine());
              
            } while (n<x || n>y);
            return n;
        }
        public static void affiche(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        }
        private static int[] remplir(int n)
        {
            int[] tab = new int[n];
            for(int i= 0; i < n; i++)
            {
                Console.WriteLine($"Donnez la valeur de l'éléments N°{i+1}");
                tab[i] = int.Parse(Console.ReadLine());
            }
            return tab;
         }

        private static int lire()
        {
            int n;
            do
            {
                Console.WriteLine("Donnez la taille du tableau");
                n = int.Parse(Console.ReadLine());
            } while (n < 2 || n > 20);

            return n;
        }

        private static int minmum(int[] tab, int x, int y)
        {
            int min = tab[x-1];
            for (int i = x; i < y; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            return min;
        }

        private static int maximum(int[] tab,int x,int y)
        {
            int max = tab[x-1];
            for (int i = x; i < y; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }
            return max;
        }
    }
}
