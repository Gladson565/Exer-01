using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, tempo;

            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digte o tempo de serviço");
            tempo = int.Parse(Console.ReadLine());

            if (idade > 65 || tempo > 35)
            {
                Console.WriteLine("Pode aposentar");
            }
            else if (idade > 60 && tempo > 25)
            {
                Console.WriteLine("Pode aposentar");
            }
            else
            {
                Console.WriteLine("Não pode aposentar");
            }
            Console.ReadLine();
        }
    }
}
