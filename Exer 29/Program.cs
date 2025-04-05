using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont2 = 0, cont = 0, respostaCerta, resposta;
            int respostaErrada = 0;
           

            while (cont < 5)
            {
                Random random = new Random();
                int soma1 = random.Next(1, 100);
                int soma2 = random.Next(1, 100);
                Console.WriteLine("============");
                Console.WriteLine("Prova de matematica");
                Console.WriteLine(soma1 + "+" + soma2);
                resposta = int.Parse(Console.ReadLine());
                respostaCerta = soma1 + soma2;
                Console.WriteLine("============");
                Console.WriteLine("Respota certa: " + respostaCerta);
                cont++;

                if (resposta == respostaCerta)
                {
                    cont2++;
                }
                else if (respostaCerta != respostaErrada)
                {
                    respostaErrada++;
                }
            }
            Console.WriteLine($"Voce acertou {cont2++} e errou {respostaErrada}");
        }
    }
}