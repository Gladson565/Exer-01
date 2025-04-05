using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_36
{
    class Program
    {
        static void Main(string[] args)
        {
            double venda, comissao;

            Console.WriteLine("Qual foi o valor da venda");
            venda = double.Parse(Console.ReadLine());  

            if (venda >= 100.000)
            {
                comissao = (0.16 * venda) / 100;
                Console.WriteLine($"O valor de da comissão é de R${comissao + 700}");
            }
            else if (venda < 100.000 && venda >= 80.000)
            {
                comissao = (0.14 * venda) / 100;
                Console.WriteLine($"O valor de da comissão é de R${comissao + 650}");
            }
            else if (venda < 80.000 && venda >= 60.000)
            {
                comissao = (0.14 * venda) / 100;
                Console.WriteLine($"O valor de da comissão é de R${comissao + 600}");

            }
            else if (venda < 60.000 && venda >= 40.000)
            {
                comissao = (0.14 * venda) / 100;
                Console.WriteLine($"O valor de da comissão é de R${comissao + 550}");
            }
            else if (venda < 40.000 && venda >= 20.000)
            {
                comissao = (0.14 * venda) / 100;
                Console.WriteLine($"O valor de da comissão é de R${comissao + 500}");
            }
            else if (venda < 20.000)
            {
                comissao = (0.14 * venda) / 100;
                Console.WriteLine($"O valor de da comissão é de R${comissao + 400}");
            }
            Console.ReadLine();
        }
    }
}
