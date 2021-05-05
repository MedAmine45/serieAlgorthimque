using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMIS
{
    class Program
    {
        public static void lire(ref int n,ref int m)
        {
            
            do
            {
                Console.WriteLine("Donnez un entier strictement positif");
                Console.Write("n =");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Donnez un entier strictement positif");
                Console.Write("m =");
                m = int.Parse(Console.ReadLine());
            } while (n <= 0 || m <= 0);
        }
        public static int sommeDiv(int x)
        {
            int s = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    s += i;
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n = 0, m = 0;
            lire(ref n,ref m);
            if (((sommeDiv(m) - m) == n) && ((sommeDiv(n) - n) == m))
            {
                Console.WriteLine(m + " et " + n + " sont deux nombres amis");
            }
            else
            {
                Console.WriteLine(m + " et " + n + " ne sont pas deux nombres amis");
            }
            Console.ReadKey();
        }
    }
}
