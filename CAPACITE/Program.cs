using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPACITE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capacité en bits:");
            Console.Write("Capacité =");
            double bits = double.Parse(Console.ReadLine());
            double o = bits / 8;
            double ko = o / 1024;
            double Mo = ko / 1024;
            double Go = Mo / 1024;
            Console.WriteLine(bits + " bits = " + o + " octets = " + ko + " Ko = " + Mo + "Mo =" + Go + " Go");
            Console.ReadKey();
        }
    }
}
