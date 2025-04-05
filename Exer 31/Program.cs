using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_31
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso;

            Console.WriteLine("Informe seu peso");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura");
            altura = double.Parse(Console.ReadLine());

            if (altura < 1.20 && peso < 60.0)
            {
                Console.WriteLine("A");
            }
            else if (altura < 1.20 && peso >= 60.0 && peso < 90.0)
            {
                Console.WriteLine("D");
            }
            else if (altura < 1.20 && peso >= 90.0)
            {
                Console.WriteLine("G");
            }
            else if (altura >= 1.20 && altura <= 1.70 && peso < 60)
            {
                Console.WriteLine("B");
            }
            else if (altura >= 1.20 && altura <= 1.70 && peso >= 60.0 && peso < 90.0)
            {
                Console.WriteLine("E");
            }
            else if (altura >= 1.20 && altura <= 1.70 && peso >= 90.0) 
            {
                Console.WriteLine("H");
            }
            else if (altura > 1.170 && peso < 60.0)
            {
                Console.WriteLine("C");
            }
            else if (altura > 1.70 && peso >= 60.0 && peso < 90.0)
            {
                Console.WriteLine("F");
            }
            else if (altura > 1.70 && peso > 90.0)
            {
                Console.WriteLine("I");
            }
            Console.ReadLine();

        }
    }
}
