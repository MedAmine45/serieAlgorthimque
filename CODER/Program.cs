using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODER
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch;
            do
            {
                Console.WriteLine("Tapez une chaîne");
                ch = Console.ReadLine();
            } while (ch.Length < 3 || ch.Length > 255);
            StringBuilder ch_codee = new StringBuilder(ch);

            for (int i = 1; i < ch.Length; i += 2)
            {
                ch_codee[i - 1] = ch[i];
                ch_codee[i] = ch[i - 1];
            }

     
            Console.WriteLine($"Le codage de la chaîne de caractère: {ch}  Donne {ch_codee}");
           
            Console.ReadKey();
        }
    }
}
