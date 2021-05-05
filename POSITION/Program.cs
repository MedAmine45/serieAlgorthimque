using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POSITION
{
    class Program
    {
        public static int[] remplir()
        {
            int[] tab = new int[20];
            for (int i = 0; i < 20; i++)
            {
                do
                {
                    Console.WriteLine($"Donnez la valeur de l'élément N° {i + 1} ");
                    tab[i] = int.Parse(Console.ReadLine());
                } while (tab[i] <= 0);

            }
            return tab;

        }
        public static void affichertableau(int[] tab)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        }

        public static void Lire(ref int x ,ref int y)
        {
            do
            {
                Console.WriteLine("Tapez les deux positions");
                Console.Write(" x =  ");
                x = int.Parse(Console.ReadLine());
                Console.Write(" y = ");
                y = int.Parse(Console.ReadLine());
            } while ((x < 1 || x > y-1 ) || y> 20 );
        }

        public static void afficher(int[] tab,int x,int y)
        {
            int min = tab[x];
            int max = tab[x];
            double moy = 0;
            Console.WriteLine($"les éléments compris entre {x} et {y} sont ");
            for(int i = x-1; i <= y-1; i++)
            {
                Console.Write($"{tab[i]} |");
                moy += tab[i];
                if (min > tab[i]) min = tab[i];
                if (max < tab[i]) max = tab[i];
            }
            moy = moy / (y - x);
            Console.WriteLine($"Leur moyenne arithmétique = {moy}");
            Console.WriteLine($"La valeur maximale = {max}");
            Console.WriteLine($"La valeur minimale  = {min}");

        }
        static void Main(string[] args)
        {
            int[] tab = remplir();
            Console.WriteLine("--------------------");
            affichertableau(tab);
            int x = 0, y = 0 ;
            Lire(ref x, ref y);
            Console.WriteLine("\n");
            Console.WriteLine("--------------------");
            afficher(tab, x, y);

            Console.ReadKey();
        }
    }
}
