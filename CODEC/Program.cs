using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tapez la valeur de l'octet");
            string octet = Console.ReadLine();
            bool ok = true;
            int occ = 1;
            string octet_comp = "";

            for (int i = 0; i < octet.Length; i++)
            {
                if((octet[i] !='0'&&octet[i] != '1')|| octet.Length != 8)
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                Console.WriteLine("la chaine n'est pas sous format d'un octet");
            }else
            {
                    Console.WriteLine("----------------------------");
                int i = 1;
                while (i < 8)
                {
                    while ( i < 8)
                    {
                        if (octet[i - 1] == octet[i])
                        {
                            occ++;
                            i++;
                           
                        }
                        else
                        {
                            break;
                        }
                           
                    }
                       
                    if (occ == 1)
                    {
                        octet_comp += octet[i - 1];
                    }
                    else
                    {
                        
                        octet_comp += occ.ToString();
                        octet_comp += octet[i-1];
                        occ = 1;
                    }
                    i++;
                }
                Console.WriteLine($"Si octet = {octet} Alors l'octet compressé est : {octet_comp}");

            }
            Console.ReadKey();
        }
    }
}
