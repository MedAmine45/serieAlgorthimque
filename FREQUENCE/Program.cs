using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FREQUENCE
{
    class Program
    {
        static  int lire()
        {
            int n =0;
            do
            {
                try
                {
                    Console.WriteLine("Donnez la taille de votre chaîne");
                    n = int.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
              
            } while (n < 5 || n > 20);
            return n;
        }
        static string lire_ch(int n)
        {
            string ch;
            do
            {
                Console.WriteLine("Tapez votre chaîne");
                ch = Console.ReadLine();

            } while (ch.Length != n);
            return ch;
        }
        static void occurrences(string ch, ref  Dictionary<char,int> occ)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsLetter(ch[i])&&!occ.ContainsKey(char.ToUpper(ch[i])))
                {
                    occ.Add(char.ToUpper(ch[i]), occurence(ch[i], ch));

                }
            }

        }

        private static int occurence(char c, string ch)
        {
            int occ = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (c == ch[i])
                {
                    occ++; ;
                }
            }
            return occ;
        }

        static void Main(string[] args)
        {
            int n = lire();
            string ch = lire_ch(n);
            Dictionary<char, int> occ = new Dictionary<char, int>();
             occurrences(ch, ref occ);
           afficher(occ);
            Console.ReadKey();
        }

        private static void afficher(Dictionary<char, int> occ)
        {
            Console.WriteLine("Le(s) lettre(s) alphabétique(s)le(s) plus utilisée(s):");
            char[] letters = occ.Keys.ToArray();
            int[] occurentes = occ.Values.ToArray();
            
            for(int i= 0; i< occ.Count(); i++)
            {
                if(occurentes[i] == occ.Values.Max())
                {
                    Console.WriteLine(letters[i]);
                }
                
            }
        }
    }
}
