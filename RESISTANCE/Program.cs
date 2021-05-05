using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESISTANCE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez les valeurs des résistances R1,R2,R3 et R4");
            Console.Write("R1 = ");
            decimal r1 = decimal.Parse(Console.ReadLine());
            Console.Write("R2 = ");
            decimal r2 = decimal.Parse(Console.ReadLine());
            Console.Write("R3 = ");
            decimal r3 = decimal.Parse(Console.ReadLine());
            Console.Write("R4 = ");
            decimal r4 = decimal.Parse(Console.ReadLine());
            decimal re = ((r1 * r2) / (r1 + r2)) + r3 + r4;
            Console.WriteLine("la résistance  équivalente RE du circuit =  " + re);
            Console.ReadKey();
        }
    }
}
