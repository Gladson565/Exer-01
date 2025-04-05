using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;
            Console.WriteLine("Trabalho de laboratório");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Avaliãção semestral");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Exame final");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 * 2 + n2 * 3 + n3 * 5) / (2 + 3 + 5);

            if (media > 0 && media < 2.9)
            {
                Console.WriteLine("Reprovado");
            }
            else if (media > 3.0 && media < 4.9)
            {
                Console.WriteLine("Recupeação");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
            Console.ReadLine();
        }
    }
}
