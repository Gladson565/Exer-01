using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,n2,n3, media; // n = nota
            Console.WriteLine("Informe as 3 notas");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            media = n1 * 1 + n2 * 1 + n3 * 2 / 1 + 1 + 2;

            if (media >= 60)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            Console.ReadLine();
        }
    }
}
