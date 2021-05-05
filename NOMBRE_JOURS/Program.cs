using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NOMBRE_JOURS
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Donner le mois (N°)");
            int month = int.Parse(Console.ReadLine());
            int days = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    Console.WriteLine("Donnez l'année");
                    int annee = int.Parse(Console.ReadLine());
                    if (annee % 4 == 0)
                        days = 29;
                    else
                        days = 28;
                    break;
                default:
                    Console.WriteLine("erreur de numéro de mois ");
                    break;
            }
            if(days != 0)
            {
                Console.WriteLine("Le nombre de jours du mois " + month + " est de " + days);

            }

            //int year, month;
            //Console.WriteLine("Donner le mois (N°)");
            //month = int.Parse(Console.ReadLine());
            //Console.WriteLine("'Donnez l\"année'");
            //year = int.Parse(Console.ReadLine());
            //int days = DateTime.DaysInMonth(year, month);
            //Console.WriteLine("'Le nombre de jours du mois " + month + " est de " + days);
            Console.ReadKey();
        }
    }
}
