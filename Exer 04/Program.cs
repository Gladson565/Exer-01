using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, quadrado, raiz;
            Console.WriteLine("insira um valor");
            num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                raiz = Math.Sqrt(num);
                quadrado = Math.Pow(num, 2);
                Console.WriteLine($"O número {num} ao quadrado é {quadrado} e a raiz quadrada é {raiz}");
            }
            else
            {
                Console.WriteLine("Número Invalido");
            }
            Console.ReadLine();
        }
    }
}
