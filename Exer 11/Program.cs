using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,digito, soma = 0;
            Console.WriteLine("Digite um valor");   
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                digito = num % 10;
                soma = soma + digito;
                num = (num - digito) / 10;
               
            }
            Console.WriteLine("Soma dos algarismo é: " + soma);
            Console.ReadLine();
        }
    }
}
