using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ELEMENTS_DIFFERENTS
{
    class Program
    {
        public  static int lire_entier()
        {
            int x;
            do
            {
                Console.WriteLine("Donnez le nombre des éléments du tableau ");
                x = int.Parse(Console.ReadLine());
            } while (x < 2 || x > 20);
            return x;
        }

        public static int[] lire_tableau(int x)
        {
            int[] tab = new int[x];
            for(int i= 0; i< x; i++)
            {
                do
                {
                    Console.WriteLine($"Donnez la valeur de l'élément N° {i + 1} ");
                    tab[i] = int.Parse(Console.ReadLine());
                } while (tab[i] <= 0);
               
            }
            return tab;

        }
        public  static void affichertableau(int[] tab, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        }
        public static void garder(int[] vec , int n)
        {
            for(int i = 0; i<n-1; i++)
            {
                for(int j= i+1; j < n; j++)
                {
                    if (vec[i] == vec[j])
                        vec[j] = 0;
                }
            }
        }
        public static void regrouper(ref int[] vec, ref int n)
        {
            int[] vect = new int[n];
            int ind1 = 0;
            int ind2 = n-1;
            for( int i = 0; i < n; i++)
            {
                if (vec[i] > 0)
                {
                    
                    vect[ind1] = vec[i];
                    ind1++;


                }
                else
                {
                    vect[ind2] = vec[i];
                    ind2--;
                }
            }
            n = ind1;
            vec = vect;

        }
        static void Main(string[] args)
        {
            int n = lire_entier();
            int[] tab = lire_tableau(n);
            Console.WriteLine("--------------------");
            affichertableau(tab, n);
            garder(tab, n);
            Console.WriteLine("\n");
            Console.WriteLine("--------------------");
            affichertableau(tab, n);
            int taille = n;
            regrouper(ref tab, ref n);
            Console.WriteLine("\n");
            Console.WriteLine($"il y a {n} élements différentes dans notre tableau ");
            Console.WriteLine("--------------------");

            affichertableau(tab, taille);






            Console.ReadKey();
        }

        
    }
}
