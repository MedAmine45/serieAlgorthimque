using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            do
            {
                Console.WriteLine("Donnez deux entiers non nuls");
                Console.Write("a= ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b= ");
                b = int.Parse(Console.ReadLine());

            } while (a == 0 || b == 0);

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;

            }
            Console.WriteLine($"PGCD = {a}");
            Console.ReadLine();
        }
    }
}
