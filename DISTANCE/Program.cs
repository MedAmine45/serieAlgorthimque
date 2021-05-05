using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISTANCE
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, r;
            Console.WriteLine("Donnez les coordonnées du premier point (M)");
            Console.Write("a  = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b  = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Donnez les coordonnées du premier point (N)");
            Console.Write("c  = ");
            c = double.Parse(Console.ReadLine());
            Console.Write("d  = ");
            d = double.Parse(Console.ReadLine());
            r = Math.Sqrt(Math.Pow((a - c), 2) + Math.Pow((b - d), 2));
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("d(M,N) = " + r);
            Console.ReadKey();
        }
    }
}
