using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOYENNEPOSITIVE
{
    class Program
    {
        public static int lire()
        {
            int n;
            do
            {
                Console.WriteLine("Donnez la taille maximale de deux tableaux");
                Console.Write("n =");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 25);
            return n;
        }
        public static double[] remplir(int n)
        {
            double[] Tab = new double[n];
            for (int i = 0; i < n; i++)
            {
                
                    Console.WriteLine($"Donnez la valeur de l'élément N°{ i + 1}");
                    Tab[i] = double.Parse(Console.ReadLine());
               

            }
            return Tab;
        }
        public static void afficher(double[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        }
        static void Main(string[] args)
        {
            int n = lire();
            double[] P = new double[n];
            P = remplir(n);
            Console.Write("\n  le tableau P : \n");
           // Console.WriteLine("----------------------");
            afficher(P);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            double[] Q = new double[n];
            Q = remplir(n);
            Console.Write("\n le tableau Q : \n");
            //Console.WriteLine("----------------------");
            afficher(Q);
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------");
            double[] TPOS = new double[n*2];
            TPOS = ranger(P, Q);
            Console.Write("\n le tableau TPOS : \n");
            afficher(TPOS);
            double moy = calculer(TPOS);
            Console.WriteLine($"La moyenne arithmétique des éléments positIfs des deux tableau ={moy} ");
            Console.ReadKey();
        }

        private static double calculer(double[] tPOS)
        {
            double moy = tPOS[0];
            for(int i = 1; i < tPOS.Length; i++)
            {
                moy += tPOS[i]; 
            }
            moy /= tPOS.Length;
            return moy;
        }

        private static double[] ranger(double[] p, double[] q)
        {
            double[] TP = new double[p.Length * 2];
            int j = 0;
            for(int i= 0; i < p.Length; i++)
            {
                if (p[i] > 0)
                {
                    TP[j] = p[i];
                    j++;
                }
            }
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] > 0)
                {
                    TP[j] = p[i];
                    j++;
                }
            }
            return TP;
        }
    }
}
