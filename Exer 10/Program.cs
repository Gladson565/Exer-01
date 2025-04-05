using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, pesoI;
            char sexo;

            Console.WriteLine("Informe o seu sexo: (com F para mulher e M para homem");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua altura: ");
            altura = double.Parse(Console.ReadLine());

            if (sexo == 'F')
            {
                pesoI = (62.1 * altura) - 44.7;
                Console.WriteLine($"O seu peso ideal é {pesoI}");
            }
            else
            {
                pesoI = (72.7 * altura) - 58;
                Console.WriteLine($"O seu peso ideal é {pesoI}");

            }
            Console.ReadLine();
        }
    }
}
