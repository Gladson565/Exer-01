using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double prestacao, salario, porcentagem;

            Console.WriteLine("Qual o valor do salário ?");
            salario = double.Parse(Console.ReadLine());


            Console.WriteLine("Qual o valor da prestação ?");
            prestacao = double.Parse(Console.ReadLine());

            porcentagem = ( 20.0 /100 ) * salario;

            if (porcentagem < prestacao)
            {
                Console.WriteLine("Empréstimo não concedido");
            }
            else
            {
                Console.WriteLine("Empréstimo concedido");
            }
            Console.ReadLine();
        }
    }
}
