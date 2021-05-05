using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OLYMPIQUE
{
    class Program
    {
        public static int lire()
        {
            int n;
            do
            {
                Console.WriteLine("donnez la taille de tableau");
                n = int.Parse(Console.ReadLine());

            } while (n < 5 || n > 20);

            return n;
        }
        public static bool isDistinct(double[] tab)
        {
            bool ok = true;
            for(int i = 0; i < tab.Length; i++)
            {
              for(int j= i + 1; j < tab.Length - 1; j++)
                {
                    if(tab[j] == tab[i] && tab[i] !=0)
                    {
                        ok = false;
                    }
                }
            }
            return ok;
        }
        public static double[] remplir(int n)
        {
            double[] tab = new double[n];
            for(int i =0;i<n;i++)
            {
                do
                {
                    Console.WriteLine($"Donnez la valeur de l'élément N° {i + 1}");
                    tab[i] = double.Parse(Console.ReadLine());


                }
                while (!isDistinct(tab) || tab[i] == 0);
            }

            return tab;
        }

        public static void affiche(double[] tab) {
            for(int i= 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        } 
        static void Main(string[] args)
        {
            int n = lire();

            double[] tab = remplir(n);
            Console.WriteLine("-----------------------");

            Console.WriteLine("\n le tableau \n");

            affiche(tab);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------");
            double moy = moyenne_oly2(tab);
            Console.WriteLine($"La moyenne olympique de cet ensemble = {moy} ");
            Console.ReadKey();
        }

        private static double moyenne_oly2(double[] tab)
        {
            double s = tab[0];
            double min = s;
            double max = s;
            for(int i= 1; i < tab.Length; i++)
            {
                s += tab[i];
                if (min > tab[i]) min = tab[i];
                if (max < tab[i]) max = tab[i];
            }
            return (s - min - max) / (tab.Length - 2);
        }
        private static double moyenne_oly(double[] tab)
        {
            double som = 0;
            for(int i = 0; i < tab.Length; i++)
            {
                if(tab[i] != maximum(tab) && tab[i] != minmum(tab))
                {
                    som += tab[i];
                }
            }

            double moy = som / (tab.Length - 2);
            return moy;
        }

        private static double minmum(double[] tab)
        {
            double min = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            return min;
        }

        private static double maximum( double[] tab)
        {
            double max = tab[0];
            for (int i = 0; i < tab.Length; i++)
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
