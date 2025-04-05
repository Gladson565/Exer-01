using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer__30
{
    class Program
    {
        static void Main(string[] args)
        {
            //ordem crescente
            int num1,num2,num3;

            Console.WriteLine("Digite tres números");
            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());
            num3=int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"{num3},{num2},{num1}");
                }
                else if (num1 > num3)
                {
                    Console.WriteLine($"{num2},{num3},{num1}");
                }
                else
                {
                    Console.WriteLine($"{num1},{num2},{num3}");
                }
                    
            }
            else if (num2 > num3)
            {
                if(num1 > num3)
                {
                    Console.WriteLine($"{num3},{num1},{num2}");
                }
                else
                {
                    Console.WriteLine($"{num1},{num3},{num1}");
                }
            }
            else
            {
                Console.WriteLine($"{num1},{num2},{num3}");
            }
            Console.ReadLine();
            
        }
    }
}
