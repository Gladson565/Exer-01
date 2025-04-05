using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c; // v = verificar se é um triangulo 
            Console.WriteLine("Informe os lados do triangulo");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());




            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("É um triângulo ");
                if (a == b && b == c & c == a)
                {
                    Console.WriteLine(" Equilátero");
                }
                else if (a == b || b == c || c == a)
                {
                    Console.WriteLine(" Isósceles");
                }
                else
                {
                    Console.WriteLine(" Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não e triângulo");
            }
                Console.ReadLine();
        }
    }
}
