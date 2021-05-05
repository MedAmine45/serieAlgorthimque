using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCCURENCES
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch;
            Dictionary<char,int> occ = new Dictionary<char, int>();
            Console.WriteLine("Tapez votre texte");
            Console.Write("ch = ");
            ch = Console.ReadLine();
            for (int i = 0; i < ch.Length; i++)
            {
                if (!occ.ContainsKey(char.ToUpper(ch[i])))
                {
                    occ.Add(char.ToUpper(ch[i]), occurence(ch[i], ch));

                }
            }
            char[] letters = occ.Keys.ToArray();
            int[] occurences = occ.Values.ToArray();
            for(int i= 0; i < occ.Count; i++)
            {
                Console.WriteLine($" {letters[i]} existe  {occurences[i]} fois dans \"{ch}\"");
            }
             Console.ReadKey();


        }
        public static int occurence(char c, string ch)
        {
            int occ = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if(c == ch[i])
                {
                    occ++; ;
                }
            }
            return occ;
        }
    }
}
