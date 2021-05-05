using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFFICHAGE
{
    class Program
    {
        public static string lire()
        {
            string ch;
            do
            {
                Console.WriteLine("Tapez une chaîne :");

                ch = Console.ReadLine();
            } while (ch.Length < 5);
            return ch;
        }

        public static void afficher(string ch)
        {
          
            for(int i= 1; i <= ch.Length; i++) {
                Console.WriteLine(ch.Substring(0, i) + ch.Substring(ch.Length - i, i));
            }
        }
        static void Main(string[] args)
        {
            string CHM = lire();
            afficher(CHM);
            Console.ReadKey();
        }
    }
}
