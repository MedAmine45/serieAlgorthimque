using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAT_PERSONNE
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexe;
            do
            {
                Console.WriteLine("Donnez le sexe de la personne (M/F)'");
                Console.Write("le sexe = ");
                sexe = Char.Parse(Console.ReadLine());
            }
            while (sexe != 'm' && sexe != 'M' && sexe != 'f' && sexe != 'F');
            
            Console.WriteLine("Donnez la taille de la personne en Cm");
            double taille = double.Parse(Console.ReadLine());
            Console.WriteLine($"la taille =  {taille} (cm)");
            Console.WriteLine("Donnez le poids de la personne en Kg"); 
            double poids = double.Parse(Console.ReadLine());
            Console.WriteLine($"le poids = {poids} (kg) ");

            double PI =0 ; 
            if(char.ToUpper(sexe) == 'M')
            {
                PI = (taille - 100) - (taille - 150) / 4;
            }else if(char.ToUpper(sexe) == 'F')
            {
                PI = (taille - 100) - (taille - 120) / 4;
            }

            Console.WriteLine($"le poids idéal d’une personne =  {PI} (cm)");
            double BMI = poids / Math.Pow((taille / 100), 2);
            Console.WriteLine("l'indicateur d'obésité BMI(Body Mass Index) = {BMI} (kg/m2))");
            if (BMI <= 27)
                Console.WriteLine("La personne est Normale");
            else if ((BMI > 27) && (BMI < 32))
                Console.WriteLine("La personne est Obèse");
            else
                Console.WriteLine("La personne est Malade");
            Console.ReadKey();

        }
    }
}
