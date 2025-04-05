using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int cardapio;
            double calculo;
            Console.Write("Especificações  ");
              Console.Write("|");
            Console.Write("Código");
            Console.Write("|");
            Console.Write("Preço");
            Console.WriteLine();
            Console.WriteLine("Cachorro Quente | 100  | 1,20");
            Console.WriteLine("Bauru Simples   | 101  | 1,30");
            Console.WriteLine("Bauru com Ovo   | 102  | 1,50");
            Console.WriteLine("Hamburguer      | 103  | 1,20");
            Console.WriteLine("Cheesburguer    | 104  | 1,70");
            Console.WriteLine("Suco            | 105  | 2,20");
            Console.WriteLine("Refrigerante    | 106  | 1,00");
            cardapio = int .Parse(Console.ReadLine());
            Console.WriteLine("Quantas unidades?");
            int unidade = int .Parse(Console.ReadLine());

            if (cardapio == 100)
            {
                calculo = unidade * 1.20;
                Console.WriteLine($"Pague R${calculo}");
                Console.WriteLine("Retira seu cachorro quente");
            }
            else if (cardapio == 101)
            {
                calculo = unidade * 1.30;
                Console.WriteLine($"Pague R${calculo}");
                Console.WriteLine("Retira seu bauru simples");
            }
            else if (cardapio == 102)
            {
                calculo = unidade * 1.50;
                Console.WriteLine($"Pague R${calculo}");
                Console.WriteLine("Retira seu bauru com ovo");
            }
            else if (cardapio == 103)
            {
                calculo = unidade * 1.20;
                Console.WriteLine($"Pague R${calculo}");
                Console.WriteLine("Retira seu hamburguer");
            }
            else if (cardapio == 104)
            {
                calculo = unidade * 1.70;
                Console.WriteLine($"Pague R${calculo}");
                Console.WriteLine("Retira seu cheesburguer");
            }
            else if (cardapio == 105)
            {
                calculo = unidade * 2.20;
                Console.WriteLine($"Pague R${calculo}");
                Console.WriteLine("Retira seu suco");
            }
            else if (cardapio == 106)
            {
                calculo = unidade * 1.00;
                Console.WriteLine($"Pague R${calculo}");
                Console.WriteLine("Retira seu refrigerante");
            }
            else
            {
                Console.WriteLine("Opção invalida");
            }

                Console.ReadLine();
        }
    }
}
