using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, raiz;
            Console.WriteLine("Insira um valor");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                raiz = Math.Sqrt(num);
                Console.WriteLine($"A raiz quadrada de {num} é {raiz}");
            }
            else
            {
                Console.WriteLine("Número Inválido");
            }
            Console.ReadLine();
        }
    }
}
