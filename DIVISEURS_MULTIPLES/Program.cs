using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIVISEURS_MULTIPLES
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = lire();
            int[] tab = remplir(n);
            Console.WriteLine("-----------------------");

            Console.WriteLine("\n le tableau T \n");

            affiche(tab);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------");
            int ind_sup = 0;
            
            do
            {
                Console.WriteLine("Donnez l'indice supérieur");
                ind_sup = int.Parse(Console.ReadLine());
            } while (ind_sup < 1 || ind_sup > n);

            int ind_inf = 0;
            do
            {
                Console.WriteLine("Donnez l'indice inférieur");
                ind_inf = int.Parse(Console.ReadLine());
            } while (ind_inf < 1 || ind_inf > ind_sup);

            Console.WriteLine("Tapez l'entier qu'on cherche ces diviseurs et ces multiples");
            int p = int.Parse(Console.ReadLine());
            string diviseurs = "";
            string multiples = "";
            for (int i = ind_inf; i < ind_sup; i++)
            {
                if (tab[i] < p)
                {
                    if (diviseur(tab[i], p)) {
                        diviseurs += tab[i].ToString() +  " ";
                    }
                }
                else
                {
                    if (diviseur(p, tab[i]))
                    {
                        multiples += tab[i].ToString() + " ";
                    }

                }
            }

            Console.WriteLine($"Les diviseurs de {p} sont : {diviseurs}");
            Console.WriteLine($"Les multiples de {p} sont :{multiples}");
            Console.ReadKey();
        }


        public static bool diviseur(int x,int y)
        {
            bool diviseur = false;
            if( y%x == 0)
            {
                diviseur = true;
            }
            return diviseur;
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

            } while (n < 1 || n > 15);

            return n;
        }
    }
}
