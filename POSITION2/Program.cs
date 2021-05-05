using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSITION2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapez un caractère'");
            Console.Write("c = ");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine("Tapez une chaîne de caractère");
            Console.Write("ch = ");
            string ch = Console.ReadLine();

            int p1 = position(ch, c);



            string chaineextrait = ch.Substring(p1);
            int p2 = position(chaineextrait, c);

            int deuxiemeposition = p1 + p2;
            Console.WriteLine("La deuxième position de " + c + " dans " + ch + " = " + deuxiemeposition);
            Console.ReadKey();
        }
        public static int position(string chaine, char c)
        {
            int p = 0;
            for (int i = 0; i <= chaine.Length; i++)
            {
                if (chaine[i] == c)
                {
                    p = i + 1;
                    break;
                }
            }
            return p;
        }
    }
}
