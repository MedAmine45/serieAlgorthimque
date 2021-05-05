using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ECART_MINIMAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = lire();
            int[] tab = remplir(n);
            Console.WriteLine("-----------------------");

            Console.WriteLine("\n le tableau V \n");

            affiche(tab);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------");
            int i = 0;
            int s1 = 0;
            int s2 = 0;
            while (s1 <= s2 && i != n-1)
            {
                s1 = somme(tab, 0, i);
                s2 = somme(tab, i+1, n);

                i++;
            }
            Console.WriteLine($"S1 = {s1} , S2 = {s2} et ind = {i}");
            Console.ReadKey();
        }

        public static int somme(int[] tab , int p1 ,int p2)
        {
            int s = 0;
            for(int i= p1; i < p2 ; i++)
            {
                s += tab[i];
            }
            return s;
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
            for (int i = 0; i < n; i++)
            {
                do
                {
                    try
                    {
                        Console.WriteLine($"Donnez la valeur de l'éléments N°{i + 1}");
                    tab[i] = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("le tableau doit  contient seulement des  entiers strictement positifs ");
                    }
                } while (tab[i] <= 0);
               
            }
            return tab;
        }
        private static int lire()
        {
            int n = 0;
            do
            {
                try
                {
                    Console.WriteLine("Donnez la taille du tableau");
                    n = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("la taille du tableau est un entier ");
                }

            } while (n < 5 || n > 20);

            return n;
        }
    }
}
