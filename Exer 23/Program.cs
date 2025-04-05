using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            Console.WriteLine("Digite um ano");
            ano = int.Parse(Console.ReadLine());

            if ((ano % 400 == 0 || ano % 4 == 0) && (ano % 100 != 0))
            {
                Console.WriteLine("Ano bissexto");
            }
            else
            {
                Console.WriteLine("Ano não e bissexto");
            }
            Console.ReadLine();
        }
    }
}
