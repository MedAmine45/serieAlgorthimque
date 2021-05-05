using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plus_grande
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n;
                do
                {
                    Console.WriteLine("Donnez le nombre des éléments du Tableau");
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                } while (n < 5 || n > 20);

                int[] tab = new int[n];
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine("Donnez la valeur de l'élément N° " + (i + 1));
                    tab[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("les éléments données sont  :");
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.Write(tab[i] + "  ");
                }
                Console.Write("\n");
                Console.WriteLine("----------------------------------------------");
                int max = tab[0];
                int indice = 0;
                for (int i = 0; i < tab.Length; i++)
                {
                    if (tab[i] > max)
                    {
                        max = tab[i];
                        indice = i ;
                    }
                }
                Console.WriteLine($"{max} C'est la plus grande valeur du tableau d'indice {indice}");
   
                Console.ReadKey();
            }
        }
    }
}