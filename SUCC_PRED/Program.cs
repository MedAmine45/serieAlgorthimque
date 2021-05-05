using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUCC_PRED
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapez un caractère : ");
            Console.Write("c = ");
            char c = char.Parse(Console.ReadLine());
            char p = c;
            Console.WriteLine("Le prédécesseur de " + c + " est " + --p);
            Console.WriteLine("Le successeur de " + c + " est " + ++c);
            Console.ReadKey();




        }
    }
}
