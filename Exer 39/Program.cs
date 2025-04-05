using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_39
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, reajuste, tempoServico;

            Console.WriteLine("Qual o sálario do funcionário ?");
            salarioAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o tempo de serviço ( para mêses use 0,2 para 2 meses, para anos use   1.0 ) ?");
            tempoServico = double .Parse(Console.ReadLine());

            if (salarioAtual <= 500 && tempoServico < 1.0)
            {
                reajuste = (0.25 * salarioAtual) / 100;
                Console.WriteLine($"Salário reajustado é de R${reajuste + salarioAtual:F2}");
                Console.WriteLine("sem bôonus");

            }
            else if (salarioAtual > 500 && salarioAtual < 1000 && tempoServico >= 1.0 && tempoServico <= 3.0)
            {
                reajuste = (0.20 * salarioAtual) / 100;
                Console.WriteLine($"Salário reajustado é de R${reajuste + salarioAtual:F2}");
                Console.WriteLine("Bônus de R$200,00");
            }
            else if (salarioAtual > 1000 && salarioAtual <= 1500 && tempoServico >= 4.0 && tempoServico <= 6.0)
            {
                reajuste = (0.15 * salarioAtual) / 100;
                Console.WriteLine($"Salário reajustado é de R${reajuste + salarioAtual:F2}");
                Console.WriteLine("Bônus de R$300,00");
            }
            else if (salarioAtual > 1500 && salarioAtual <= 2000 && tempoServico >= 7.0 && tempoServico <= 10.0)
            {
                reajuste = (0.15 * salarioAtual) / 100;
                Console.WriteLine($"Salário reajustado é de R${reajuste + salarioAtual:F2}");
                Console.WriteLine("Bônus de R$300,00");
            }
            else if (salarioAtual > 2000  && tempoServico > 10.0)
            {

                Console.WriteLine("Salário sem reajuste");
                Console.WriteLine("Bônus de R$500,00");
            }
            Console.ReadLine();

        }
    }
}
