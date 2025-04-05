
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Insira um valor");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira um valor");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"Maior número é {num1}");
            }
            else
            {
                Console.WriteLine($"Maior número é {num2}");
            }
            Console.ReadLine();
        }
    }
}
