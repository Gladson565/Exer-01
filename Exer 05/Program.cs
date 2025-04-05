using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("insira um valor");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} é par");
            }
            else
            {
                Console.WriteLine($"{num} é impar");
            }
            Console.ReadLine();
        }
    }
}
