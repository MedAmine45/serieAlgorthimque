using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARFAIT
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Les 4 premiers nombres parfaits sont:");
            int compte = 0;
            int nbr = 6;
            while (compte <4) 
            {
                int somdiv = 0;
                for (int i = 1; i <=(nbr/2); i++)
                {
                    if (nbr % i == 0)
                    {
                        somdiv += i;
                    }
                }
                if (somdiv == nbr)
                {
                    Console.Write($"{ nbr} |");
                    compte++;
                }

                nbr++;

            } 
            Console.ReadKey();
        }
    }
}
