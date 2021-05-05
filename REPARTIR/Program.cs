using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPARTIR
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

            } while (n < 6 || n > 30);

            char[] tab = new char[n];
            for (int i = 0; i < tab.Length; i++)
            {
                    Console.WriteLine($"Donnez la valeur de l'élément N° {i + 1}");
                    tab[i] = char.Parse(Console.ReadLine());
                
               
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("les éléments données sont  ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + "|");
            }
            Console.Write("\n");
          

            List<char> tl = new List<char>();
            List<char> tc = new List<char>();
            List<char> ts = new List<char>();
            for ( int i = 0; i < n; i++)
            {
                if (char.IsLetter(tab[i])){
                    tl.Add(tab[i]);
                } else if (char.IsDigit(tab[i]))
                {
                    tc.Add(tab[i]);
                    //chiffreocc++;
                } else //if(char.IsSymbol(tab[i]))
                {
                    ts.Add(tab[i]);
                }
            }
            char[] TL = tl.ToArray();
            char[] TC = tc.ToArray();
            char[] TS = ts.ToArray();
            Console.Write("\n");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Tableau des lettres");
            for (int i = 0; i < TL.Length; i++)
            {
                Console.Write(TL[i] + "|");
            }
            Console.Write("\n");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Tableau des chiffres");
            for (int i = 0; i < TC.Length; i++)
            {
                Console.Write(TC[i] + "|");
            }
            Console.Write("\n");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Tableau des symboles");
            for (int i = 0; i < TS.Length; i++)
            {
                Console.Write(TS[i] + "|");
            }



            Console.ReadKey();
        }
    }
}
