using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice
{
    class Program
    {
        public static int occurence(int n, int[] tab)
        {
            int nb = 0;
            for(int i= 0; i < tab.Length; i++)
            {
                if(tab[i]== n)
                {
                    nb++;
                }
            }
            return nb;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez la taille de votre tableau");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            for(int i= 0; i < n; i++)
            {
                Console.WriteLine($"Donnez la valeur de l'élément N° {i + 1}");
                tab[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("\n le tableau \n");

            for (int i = 0; i < tab.Length; i++)
            {

                Console.Write($"{tab[i]} |");
            }
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Tapez la valeur recherché");
            int v = int.Parse(Console.ReadLine());
            bool trv = false;
            int j = 0;
            do
            {
                trv = tab[j] == v;
                j++;

            } while (j != n && !trv);
            string rt = "";
            if (trv)
            {
                rt = $"est exsite dans  T {occurence(v, tab)} fois  ";
            }
            else
            {
                rt = "n'est pas dans T ";
            }
            Console.WriteLine("{0}  {1}", v, rt);
            /*
             Ce programme permet de saisir n entiers dans le tableau T , 
             et d'afficher si un entier donné v existe ou pas dans ce tableau   
             */
            Console.ReadKey();

        }
    }
}
