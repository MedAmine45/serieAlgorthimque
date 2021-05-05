using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rechercher_remplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string mot1, mot2,text;
            Console.WriteLine("Tapez votre texte");
            Console.Write("texte = ");
            text = Console.ReadLine();
            Console.WriteLine("Tapez le mot rechercher");
            Console.Write("mot1 = ");
            mot1 = Console.ReadLine();
            Console.WriteLine("Tapez le mot à remplacer");
            Console.Write(" mot2 = ");
            mot2 = Console.ReadLine();
            //int index = postion(mot1,text);
            text = text.Replace(mot1, mot2);

            Console.WriteLine($"Texte après modIfication:\n {text}");
            Console.ReadKey();
        }
        public static int postion(string mot, string text)
        {
            int p = 0;
            if (mot.Length > text.Length)
                return 0;
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    for(int j = 0; j < mot.Length; j++)
                    {
                        if(text[i]== mot[j])
                        {
                            p++;
                        }
                    }
                }
                return p;
            }

            
        }
    }
}
