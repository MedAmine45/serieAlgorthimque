using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATRICE
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,res = 0;
            char op;
            Console.WriteLine("Tapez la première valeur");
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Tapez la deuxième valeur");
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'opération souhaiteé ");
            op = char.Parse(Console.ReadLine());

            switch(op){
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '*':
                    res = a * b;
                    break;
                case '/':
                    res = a / b;
                    break;
            }
            Console.WriteLine($"{a} {op} {b} = {res}");
            Console.ReadKey();


        }
    }
}
