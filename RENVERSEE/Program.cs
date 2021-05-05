using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RENVERSEE
{
    class Program
    {
        public static string lire()
        {
            string ch;
            do
            {
                Console.WriteLine("Tapez votre phrase");
                Console.Write(" ch = ");
                ch = Console.ReadLine();
            }
            while (ch[0]==' '|| ch[ch.Length-1] ==' '|| !char.IsLetter(ch[0]));
            return ch;
        }
        static void Main(string[] args)
        {
            string chaine = lire();

           
            Console.WriteLine(renverser(chaine));
            Console.ReadKey();
        }

        private static string renverser(string ch)
        {

            string[] elements = ch.Split(' ');
            string ch1 = "";
            for (int i = elements.Count(); i > 0 ; i--)
            {
                
                    ch1 += elements[i-1] + " ";

                
            }


            return ch1;
        }
    }
}
