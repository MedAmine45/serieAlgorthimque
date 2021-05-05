using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = lire();
            int[] tab = former(n);

           
            afficher(tab,n) ;
            
            Console.WriteLine("\n");
            Console.WriteLine("----------------");
            Console.WriteLine("Le plus petit nombre est " + minmum(tab));
            Console.WriteLine("Le plus grand nombre est " + maximum(tab));

            former2(n);

            Console.ReadKey();
        }

        private static void afficher(int[] tab,int n)
        {
            Console.Write($"Les nombres Formés par les chiffres de {n} sont :");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} ,");
            }
        }
        public static void Commencer(int[] list)
        {
            travaille(list, 0, list.Length - 1);
        }


        private static void echange(ref int a, ref int b)
        {
            if (a == b) return;
            a ^= b;
            b ^= a;
            a ^= b;
        }


        private static void travaille(int[] list, int current, int max)
        {
            int i;
            if (current == max)
            {

                foreach (var item in list)
                {
                    Console.Write(Convert.ToString(item));
                }
                Console.WriteLine(" ");
            }
            else
                for (i = current; i <= max; i++)
                {
                    echange(ref list[current], ref list[i]);
                    travaille(list, current + 1, max); // on descend
                    echange(ref list[current], ref list[i]);
                }
        }

        private static void former2(int n)
        {
            int nb = factorille(n.ToString().Length);
            int[] tab = new int[nb];
            int c = n / 100;
            int d = (n % 100) / 10;
            int u = n % 10;
            int[] list = new int[] { c, d, u };
            Commencer(list);

            //int i = 0;
            //while (i < nb)
            //{
            //    tab[i] = n;
             
            //    n = n * 10;
            //    n = n + n % 10;
            //    n = n / 10;

            //    i++;
           // }




          //  return tab;
        }

        private static int[] former(int n)
        {
            int nb = factorille(n.ToString().Length);
            int[] tab = new int[nb];
            int c = n / 100;
            int d = (n % 100) / 10;
            int u = n % 10;
            tab[0] = n;
            tab[1] = (c * 100) + (u * 10) + d;
            tab[2] = (u * 100) + (d * 10) + c;
            tab[3] = (u * 100) + (c * 10) + d;
            tab[4] = (d * 100) + c * 10 + u;
            tab[5] = (d * 100) + (u * 10) + c;
            


            return tab;
        }

        private static int minmum(int[] tab)
        {
            int min = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            return min;
        }

        private static int maximum(int[] tab)
        {
            int max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }
            return max;
        }
        public static int factorille(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorille(n - 1);
            }
        }
        private static int lire()
        {
            int n =0 ;
            do
            {
                try
                {
                    Console.WriteLine("Donnez un entier non nul composé de trois chiffres");
                    n = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("S'il vous plait donnez la bonne format d'un entier ");
                }

            } while (n < 100 || n > 999);
            return n;
        }
    }
}
