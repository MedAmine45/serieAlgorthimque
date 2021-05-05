using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("tapez la taille du tableau");
                Console.Write(" n= ");
                n = int.Parse(Console.ReadLine());

            } while (n < 5 || n > 20);

            int[] tab = new int[n];
            for (int i = 0; i < tab.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Donnez la valeur de l'élément N° {i+1}");
                    tab[i] = int.Parse(Console.ReadLine());
                }
                while (tab[i] % 2 != 0);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("les éléments données sont  ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + "|");
            }
            Console.Write("\n");
            Console.WriteLine("----------------------------------------------");
            int somme = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                somme += tab[i];
            }
            double moyenne = somme / n;
            Console.WriteLine("la moyenne  du tableau est " + moyenne);


            Console.ReadKey();

        }
    }
}
