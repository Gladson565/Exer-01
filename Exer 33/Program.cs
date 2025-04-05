using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_33
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, percentual;

            Console.WriteLine("Informe o preço antigo");
            preco = double.Parse(Console.ReadLine());

            if (preco < 50)
            {
                percentual = (preco * 0.05) / 100;
                Console.WriteLine($"novo preço é R${percentual + preco:F2}");
            }
            else if (preco > 50 && preco  < 100)
            {
                percentual = ( preco * 0.10) / 100;
                Console.WriteLine($"novo preço é R${percentual + preco:F2}");
            }
            else if (preco >= 100)
            {
                percentual = ( preco * 0.10) / 100;
                Console.WriteLine($"novo preço é R${percentual + preco:F2}");
            }
            Console.ReadLine();
        }
    }
}
