using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("donnez le temps en seconde");
            Console.Write("temps = ");
            int n = int.Parse(Console.ReadLine());
            int h = n / 3600;
            int m = (n % 3600) / 60;
            int s = n % 60;
            Console.WriteLine(n + "s = " + h + " h : " + m + " m: "+s + " s");
            Console.ReadLine();


        }
    }
}
