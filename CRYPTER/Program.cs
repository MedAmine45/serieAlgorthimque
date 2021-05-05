using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CRYPTER
{
    public class Program
    {
         static void Main(string[] args)
        {
            int n = Lire();
            char[] tab = remplir(n);
            Console.WriteLine("--------------------");
            Console.WriteLine("\n le tableau de caratere est le suivant\n");
            afficher(tab);
            Console.WriteLine("\n");
            Console.WriteLine("--------------------");
            char[] R = new char[n];
            int code1, code2;   
            for(int i = 0; i < tab.Length; i++)
            {
                code1 =  tab[i];
                code2 = permuter(code1);
                R[i] = (char)code2;
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("\n le tableau de caratere renversée est le suivant\n");
            afficher(R);
            Console.ReadKey();
        }

        private static int permuter(int code1)
        {
            int n = 0;
            while(code1 != 0)
            {
                n = n * 10;
                n = n + code1 % 10;
                code1 = code1 / 10;
            }
            return n;
        }

        public static void afficher(char[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i]} |");
            }
        }

        private static char[] remplir(int n)
        {
            char[] tab = new char[n];
            for(int i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine($"Donnez la valeur de l'élément N° {i + 1}");
                    tab[i] = char.Parse(Console.ReadLine());
                }catch(Exception ex)
                {
                   // Console.WriteLine(ex.Message);
                    //Console.WriteLine("Please enter Name in the Correct Format Char");
                    if (ex.Message != null)
                        i --;
                }
              
            }
            return tab;

        }

        private static int Lire()
        {
            int n;
            do
            {
                Console.WriteLine("Donnez la taille du tableau");
                n = int.Parse(Console.ReadLine());
            } while (n<=2||n>=20);
            return n;
        }
    }
}
