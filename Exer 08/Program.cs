using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            Console.WriteLine("Insira as duas notas");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());

            if (nota1 > 0 && nota1 < 10 && nota2 > 0 && nota2 < 10)
            {
                media = (nota1 + nota2) / 2;
                Console.WriteLine($"A média das notas é {media}");
            }
            else
            {
                Console.WriteLine("Nota invalida");
                
            }
            Console.ReadLine();
        }
    }
}
