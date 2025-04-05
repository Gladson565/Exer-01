using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_28
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            double x, y, z;

            Console.WriteLine("Opção");
            Console.WriteLine("a) Geometrica");
            Console.WriteLine("b) Ponderada");
            Console.WriteLine("c) Harmônica");
            Console.WriteLine("d) Aritimética");
            opcao = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite 3 valores");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            if (opcao == 'a')
            {
                double expoente, produto, media;
                expoente = 1.0 / 3;
                produto = x * y * z;
                media = Math.Pow(produto, expoente);
                Console.WriteLine(media);
            }
            else if (opcao == 'b')
            {
                double pomderada = (x + 2 * y + 3 * z) / 6;
                Console.WriteLine(pomderada);
            }
            else if (opcao == 'c')
            {
                double harmonica = 1 / (1 / x + 1 / y + 1 / z);
                Console.WriteLine(harmonica);
            }
            else if(opcao == 'd')
            {
                double aritimetica = (x + y + z) / 3;
                Console.WriteLine(aritimetica);
            }
            Console.ReadLine();
        }
    }
}
