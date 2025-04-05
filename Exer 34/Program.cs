using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_34
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            int faltas;

            Console.WriteLine("Informe a nota do aluno");
            nota = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de faltas");
            faltas = int.Parse(Console.ReadLine());

            if (nota >= 9.0 && nota <= 10.0 && faltas <= 20)
            {
                Console.WriteLine("A");
            }
            else if (nota >= 7.5 && nota <= 8.9 && faltas <= 20)
            {
                Console.WriteLine("B");
            }
            else if (nota >= 5.0 && nota <= 7.4 && faltas <= 20)
            {
                Console.WriteLine("C");
            }
            else if (nota >= 4.0 && nota <= 4.9 && faltas <= 20)
            {
                Console.WriteLine("D");
            }
            else if (nota >= 0.0 && nota <= 3.9 && faltas <= 20)
            {
                Console.WriteLine("E");
            }
            else if (nota >= 9.0 && nota <= 10.0 && faltas > 20)
            {
                Console.WriteLine("B");
            }
            else if (nota >= 7.5 && nota <= 8.9 && faltas > 20)
            {
                Console.WriteLine("C");
            }
            else if (nota >= 5.0 && nota <= 7.4 && faltas > 20)
            {
                Console.WriteLine("D");
            }
            else if (nota >= 4.0 && nota <= 4.9 && faltas > 20)
            {
                Console.WriteLine("E");
            }
            else if (nota >= 0.0 && nota <= 3.9 && faltas > 20)
            {
                Console.WriteLine("E");
            }
            Console.ReadLine();
        }
    }
}
