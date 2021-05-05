using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEU
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int joueur1 = 0, joueur2 = 0;
            jouer(ref joueur1, ref joueur2);

            Console.WriteLine($"le joueur 1 a des points {joueur1}" );
            Console.WriteLine($"le joueur 2 a des points {joueur2}");

            Console.WriteLine("Le joueur gagnant c'est le joueur N°" + gagnant(joueur1, joueur2));


            //Random rmd = new Random();
            //int i= 0, j;
            //while (i < 1000)
            //{
            //    j = rmd.Next(1, 7);
            //    Console.WriteLine(j);
            //    i++;
            //}

            

            Console.ReadKey();
        }

        private static int gagnant(int joueur1, int joueur2)
        {
            if (joueur1 > joueur2)
                return 1;
            else
                return 2;
        }

        private static void jouer(ref int score1, ref int score2)
        {
            Random rmd = new Random();
            int coup1, coup2;
            while(score1 != 10 && score2 != 10)
            {
                coup1 = rmd.Next(1,7);
                coup2 = rmd.Next(1, 7);
                Console.WriteLine($"{coup1}  {coup2}");
                if (coup1 > coup2)
                    score1++;
                else
                    score2++;
                
                
            }
        }
    }
}
