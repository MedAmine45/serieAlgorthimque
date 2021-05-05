using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmax_cmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch;
            Console.WriteLine("Tapez une chaîne de chIffres"); 
            ch = Console.ReadLine();
            bool ok = true;
            //int i = 0;
           for (int i = 0; i < ch.Length; i++)
           {
                if (!char.IsDigit(ch[i]))
                {
                    ok = false;
                }
           }
            StringBuilder cmin = new StringBuilder(ch);
            StringBuilder cmax = new StringBuilder(ch);
            StringBuilder changer = new StringBuilder(ch);
            if (!ok)
            {
                Console.WriteLine("la chaine n'est pas en chiffres");
            }
            else
            {
                for (int j = 0; j < ch.Length; j++)
                {
                    int ind_max = 0;
                    for(int i = 1; i < ch.Length; i++)
                    {
                        if (ch[ind_max] < ch[i])
                        {
                            ind_max = i;
                            cmax[j]= ch[ind_max];
                            cmin[ch.Length - j - 1] = ch[ind_max];
                            changer[ind_max] = '*';
                        }
                    }
                   
                }
                Console.WriteLine($"la Combinaison minimale {cmin.ToString()}");
                Console.WriteLine($"la Combinaison maximale {cmax.ToString()}");
                Console.WriteLine($"la chaine entrer {changer.ToString()}");

            }

            
            Console.ReadKey();




        }
    }
}
