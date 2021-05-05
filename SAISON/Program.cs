using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAISON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez le numèro d'un mois ");
            int mois = int.Parse(Console.ReadLine());
            switch (mois)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Hiver");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Printemps");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Eté");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Automne");
                    break;
                default:
                    Console.WriteLine("erreur de nombre de mois ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
