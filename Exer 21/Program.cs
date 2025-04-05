using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exer_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double a, b;

            Console.WriteLine("Escolha a opção");
            Console.WriteLine("1- Soma de 2 números");
            Console.WriteLine("2- Diferença entre 2 números");
            Console.WriteLine("3- Produto entre 2 números");
            Console.WriteLine("4- Divisão entre 2 números");
            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dois valores");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());  

            if (opcao == 1)
            {
                Console.WriteLine(a + b);
            }
            else if (opcao == 2)
            {
                Console.WriteLine(a - b);
            }
            else if (opcao == 3)
            {
                Console.WriteLine(a * b);
            }
            else if (opcao == 4)
            {
                if (b > 0)
                {
                    Console.WriteLine(a / b);
                }
                else
                {
                    Console.WriteLine("O denominador não pode ser 0 ou menor que 0");
                }
            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }
            Console.ReadLine();
        }
    }
}
