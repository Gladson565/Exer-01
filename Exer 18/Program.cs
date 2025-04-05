using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, a, b, result;
            Console.WriteLine("1)Soma, 2)Subtração, 3)Multiplicação, 4)Divisão");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe 2 valores");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine(result);
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine(result);
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine(result);
                    break;
                case 4:

                   if (a > 0)
                    {
                        result = a / b;
                        Console.WriteLine(result);
                    }
                   else
                    {
                        Console.WriteLine("Não é permitido divisão por 0");
                    }
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.ReadLine();
        }
    }
}
