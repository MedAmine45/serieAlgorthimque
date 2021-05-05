using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSITION2INT
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tapez un chiffre'");
            Console.Write("chif = ");
            int chif = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez un entier");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            char c = char.Parse(chif.ToString());
            string chaine = n.ToString();
            int p1 = position(chaine, c);
            string chaineextrait = chaine.Substring(p1);
            int p2 = position(chaineextrait, c);

            int deuxiemeposition = p1 + p2;
            Console.WriteLine("La deuxième position de " + chif + " dans " + n + " = " + deuxiemeposition);

            Console.ReadLine();
        }
        public static int position(string chaine, char c)
        {
            int p = 0;
            for (int i = 0; i < chaine.Length; i++)
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
