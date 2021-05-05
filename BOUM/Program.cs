using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOUM
{
    class Program
    {
        public static int lire_n()
        {
            int n;
            do
            {
                Console.WriteLine("Donnez un entier compris entre 100 et 500");
                Console.Write("n =");
                n = int.Parse(Console.ReadLine());
            } while (n < 100 || n > 500);
            return n;
        }
        public static int lire_m()
        {
            int n;
            do
            {
                Console.WriteLine("Donnez un entier compris entre 10 et 99");
                Console.Write("m =");
                n = int.Parse(Console.ReadLine());
            } while (n < 10 || n > 99);
            return n;
        }

        public static void afficher(int m ,int n)
        {
            for(int i= 1; i <=  m; i++)
            {
                if(n%i ==0 )
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
        static void Main(string[] args)
        {
            int n = lire_n();
            int m = lire_m();
            afficher(m, n);
            Console.ReadKey();
        }
    }
}
