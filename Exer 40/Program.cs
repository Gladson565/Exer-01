using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_40
{
    class Program
    {
        static void Main(string[] args)
        {
            double custo, distribuidor, imposto;

            Console.WriteLine("Qual o custo de fábrica?");
            custo = double.Parse(Console.ReadLine());
            
            if(custo <= 12.000)
            {
                distribuidor = 0.5 * custo;
                Console.WriteLine($"O valor para o consumidor é de {distribuidor + custo:F2} insento de imposto");
            }
            else if (custo > 12.000 && custo <= 25.000)
            {
                distribuidor = 0.10 * custo ;
                imposto = 0.15 * custo;
                Console.WriteLine($"O valor para o consumidor é de {distribuidor + custo + imposto:F2} ");
            }
            else if (custo > 25.000)
            {
                distribuidor = 0.15 * custo;
                imposto = 0.20 * custo;
                Console.WriteLine($"O valor para o consumidor é de {distribuidor + custo + imposto:F2} ");
            }
            Console.ReadLine();
        }
    }
}
