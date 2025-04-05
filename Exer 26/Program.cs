using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double km, l, kml;

            Console.WriteLine("Qual a distâcia em km percorrida pelo carro?");
            km = Double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos litros de gasolina você gasta?");
            l = Double.Parse(Console.ReadLine());

            kml = km / l;

            if (kml < 8)
            {
                Console.WriteLine("Venda o carro");
            }
            else if (kml > 8 && kml < 14)
            {
                Console.WriteLine("Econômico");
            }
            else if (kml > 12)
            {
                Console.WriteLine("Super econômico");
            }
            Console.ReadLine();
        }
    }
}
