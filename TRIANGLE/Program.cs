using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = lire();
            affichage(ch);
            Console.ReadKey();
        }

        public static void affichage(string ch)
        {
            for(int i = 0; i <= ch.Length; i++)
            {
                Console.WriteLine(ch.Substring(0, i));
            }
        }
        private static string lire()
        {
            string ch;
            do{
                Console.WriteLine("Tapez une chaîne");
                ch = Console.ReadLine();
             }
            while (ch.Length<3);
            return ch;
      }
    }
}
