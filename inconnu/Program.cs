using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inconnu
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Tapez un caractère : ");
                Console.Write("c1 = ");
                char c1 = char.Parse(Console.ReadLine());
                char c2;
                if (c1 >= 97 && c1 <= 122)
                {
                    int n = Convert.ToInt32(c1);
                    c2 = Convert.ToChar(n - 32);
                }
                else
                    c2 = c1;

                Console.WriteLine("C2 = " + c2);

                Console.ReadKey();

           //Ce programme permet d'afficher un caratère C1 donnée en majuscule
           


        }
    }
}
