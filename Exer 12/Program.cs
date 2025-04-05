using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double calculo;
            Console.WriteLine("Informe um número");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Número Inválido");
            }
            else
            {
                calculo = Math.Log(num);
                Console.WriteLine(calculo);
            }
            Console.ReadLine(); 
        }
    }
}
