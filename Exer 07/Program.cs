using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Insira 2 valores");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Números iguais");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"O número {num1} é o maior");
            }
            else
            {
                Console.WriteLine($"O número {num2} é o maior");
            }
            Console.ReadLine();
        }
    }
}
