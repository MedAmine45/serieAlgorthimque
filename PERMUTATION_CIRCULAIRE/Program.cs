using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERMUTATION_CIRCULAIRE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapez trois caractère : ");
            Console.Write("c1 = ");
            char c1 = char.Parse(Console.ReadLine());
            Console.Write("c2 = ");
            char c2 = char.Parse(Console.ReadLine());
            Console.Write("c3 = ");
            char c3 = char.Parse(Console.ReadLine());

            char aux = c1;
            c1 = c3;
            c3 = c2;
            c2 = aux;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("les trois caratère aprés permutation");
            Console.WriteLine("c1 = " + c1);
            Console.WriteLine("c2 = " + c2);
            Console.WriteLine("c3 = " + c3);

            Console.ReadKey();

        }
    }
}
