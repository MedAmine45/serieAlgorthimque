using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECH_CUBIQUE
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, d, u, s;
            for (int i = 100; i <= 999; i++)
            {   
                c = i / 100;
                d = (i % 100) / 10;
                u = i % 10;
                s = c * c * c + d * d * d + u * u * u;
                if (i == s)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
