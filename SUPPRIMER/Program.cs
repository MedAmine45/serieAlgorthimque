using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SUPPRIMER
{
    class Program
    {
        public static string lire()
        {
            string  ch;
            do
            {
                Console.WriteLine("Tapez une chaîne non vide");
                Console.Write(" ch = ");
                ch = Console.ReadLine();
            }
            while (!ch.Contains(" "));
            return ch;
        }
        static void Main(string[] args)
        {
            string chaine = lire();
            superflus(ref chaine);
            Console.WriteLine($"Votre chaîne Après suppression des espaces superflus = {chaine} ");
            Console.ReadKey();  
        }

        private static void superflus(ref string ch)
        {
            
            string nouvelleChaine = "";


            string[] elements = ch.Trim().Split(' ');
            for (int i = 0; i < elements.Count(); i++)
            {
                if (elements[i] != "")
                { 
                    nouvelleChaine += elements[i]+ " ";

                }
            }
            ch = nouvelleChaine.Trim();


       
          
            
         
        }
    }
}
