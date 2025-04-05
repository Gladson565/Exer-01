using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_24
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double valor, solucao;
            string opcao;



            Console.WriteLine("Opção");
            Console.WriteLine("1-MG 7%");
            Console.WriteLine("2-SP 12%");
            Console.WriteLine("3-RJ 15%");
            Console.WriteLine("4-MS 8%");
            opcao = Console.ReadLine();

            if (opcao == "MG")
            {
                Console.WriteLine("DIgite o valor do produto");
                valor = double.Parse(Console.ReadLine());
                solucao = (7.0 * valor) / 100;
                Console.WriteLine($"O valor acrescido é de R${solucao + valor}");
            }
            else if (opcao == "SP")
            {
                Console.WriteLine("DIgite o valor do produto");
                valor = double.Parse(Console.ReadLine());
                solucao = (12.0 * valor) / 100;
                Console.WriteLine($"O valor acrescido é de R${solucao + valor}");
            }
            else if (opcao == "RJ")
            {
                Console.WriteLine("DIgite o valor do produto");
                valor = double.Parse(Console.ReadLine());
                solucao = (15.0 * valor) / 100;
                Console.WriteLine($"O valor acrescido é de R${solucao + valor}");
            }
            else if (opcao == "MS")
            {
                Console.WriteLine("DIgite o valor do produto");
                valor = double.Parse(Console.ReadLine());
                solucao = (8.0 * valor) / 100;
                Console.WriteLine($"O valor acrescido é de R${solucao + valor}");
            }
            else
            {
                Console.WriteLine("Estado invalido");
            }
                Console.ReadLine();
        }
        
    }
}
