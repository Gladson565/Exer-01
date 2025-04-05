using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, raiz, quadrada;

            Console.WriteLine("Insira um valor");
            num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                raiz = Math.Sqrt(num);
                Console.WriteLine($"A raiz quadrade de {num} é {raiz}");
            }
            else
            {
                quadrada = Math.Pow(num, 2);
                Console.WriteLine($"O número {num} ao quadrado {quadrada}");
            }
            Console.ReadLine();
        }
    }
}
