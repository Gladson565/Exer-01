using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, diferenca;
            Console.WriteLine("Insira um valor 2 valores");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            diferenca = num1 - num2;
            if (num1 > num2)
            {
               
                Console.WriteLine($"O maior número é {num1} é a diferença é de {diferenca}");
            }
            else
            {

                Console.WriteLine($"O maior número é {num2}  é a diferença é de {diferenca}");
            }
           
        }
    }
}
