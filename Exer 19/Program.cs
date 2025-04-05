using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());

            if (num % 3 == 0)
            {
                Console.WriteLine("Número é divisivel por 3");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Número é divisivel por 5");
            }
            else
            {
                Console.WriteLine("Não é divisivel nem por 3 nem por 5");
            }
            Console.ReadLine();
        }

    }
}
