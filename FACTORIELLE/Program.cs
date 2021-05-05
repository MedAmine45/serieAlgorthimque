using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORIELLE
{
    class Program
    {
        static void Main(string[] args)
        {
         
                Console.WriteLine("Donnez un entier positIf");
                Console.Write("n = ");
                uint n = uint.Parse(Console.ReadLine());
                uint f = 1;
                for (uint i = 2; i <= n; i++)
                {
                    f *= i;
                }

                    Console.WriteLine($"{n}! = {f}");
                    Console.ReadKey();
          


        }
        //2eme methode 
        public static uint factorille(uint n)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorille(n - 1);
            }
        } 
    }
}
