using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ANAGRAMME
{
    class Program
    {
        public static void lire(ref string ch1,ref string ch2)
        {
            do
            {
                Console.WriteLine("Tapez votre premier mot ");
                ch1 = Console.ReadLine();
                Console.WriteLine("Tapez votre deuxième mot ");
                ch2 = Console.ReadLine();
            } while (string.IsNullOrEmpty(ch1) || string.IsNullOrEmpty(ch2) || ch2 == ch1);

        }

        public static bool verifier(string ch1, string ch2)
        {
            return ch1.All(x => ch2.Contains(x)) && ch2.All(x => ch1.Contains(x));
        }
        static void Main(string[] args)
        {
            string mot1 = "", mot2 = "";
            lire(ref mot1, ref  mot2);
            if (verifier(mot1, mot2)){
                Console.WriteLine($"{mot2} est une anagramme de {mot1}");
            }
            else
            {
                Console.WriteLine($"{mot2} n'est pas une anagramme de {mot1}");
            }
            Console.ReadLine();

        }
    }
}
