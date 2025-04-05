using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double basemaior, basemenor, h, A;

            Console.WriteLine("Informe a base maior");
            basemaior = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a base menor");
            basemenor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura");
            h = double.Parse(Console.ReadLine());   

            if (basemaior > 0 && basemenor > 0)
            {
                A = (basemaior + basemenor) * h / 2; // formula
                Console.WriteLine("A área do traézio é " + A);
            }
            else
            {
                Console.WriteLine("As bases tem que ser maior do que 0");
            }
            Console.ReadLine();
        }
    }
}
