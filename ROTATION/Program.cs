using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROTATION
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = lire();
           // double[] A = remplir(n);
            Console.WriteLine("-----------------------");

            Console.WriteLine("\n le tableau A \n");
            double[] A = { 2.2, 6, -1.5, 30.12, 8 };
            affiche(A);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------");

            int k = lire_k(n);

            double[] B = pivoter(A, k);

            Console.WriteLine("\n le tableau T \n");

            affiche(B);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------");


            Console.ReadKey();
        }

        private static double[] pivoter(double[] a, int k)
        {
            double[] tabb = new double[a.Length];
          
            for(int i = 0; i < a.Length; i++)
            {

                //if ((i  - k) >= 0)
                //    tabb[i - k] = a[i];
                //else
                //    tabb[a.Length - k + i] = a[i];

                if (i + k < a.Length)
                {
                    tabb[i] = a[i + k];
                }
                else
                {
                    tabb[i] = a[i+k-a.Length];
                }
            }

            return tabb;
        }

        private static int lire_k(int y )
        {
            int n = 0;
            do
            {
                try
                {
                    Console.WriteLine("Donnez le nombre d'éléments de rotation");
                    n = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("le nombre d'éléments de rotation doit être un entier ");
                }

            } while (n < 1 || n > y-1);

            return n;
        }
        public static void affiche(double[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        }
        private static double[] remplir(int n)
        {
            double[] tab = new double[n];
            for (int i = 0; i < n; i++)
            {
               
                    try
                    {
                        Console.WriteLine($"Donnez la valeur de l'éléments N°{i + 1}");
                        tab[i] = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("le tableau doit  contient seulement des  entiers  ");
                         i--;
                    }
               

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
                    Console.WriteLine("la taille du tableau doit être un entier ");
                }

            } while (n < 2 || n > 25);

            return n;
        }
    }
}
