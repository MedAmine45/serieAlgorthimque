using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRAIRE
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Donnez un entier composé de trois chiffres");
                Console.Write("x  = ");
                x = int.Parse(Console.ReadLine());
            } while (x < 100 || x > 999);

            int c = x / 100;
            int d = (x % 100) / 10;
            int u = x % 10;
            Console.WriteLine("---------------------------------------------");
            
            Console.WriteLine("Centaine = " + c + " ,Dizaine = " + d + " ,Unité = " + u);
            Console.ReadKey();
        
        }
    }
}
