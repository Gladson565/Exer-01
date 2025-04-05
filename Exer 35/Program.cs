using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            Console.WriteLine("Informe a data a baixo com dia, mes e ano");
            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            ano = int.Parse(Console.ReadLine());

            if(dia >= 01 && dia <= 31)
            {
                if (mes >= 01 && mes <= 12)
                {
                    if (mes == 02 && dia >= 01 && dia <= 28)
                    {

                        if (ano >= 1900 && ano <= 2025)
                        {
                            Console.WriteLine($"{dia}/{mes}/{ano} data valida ");
                        }
                        if ((mes == 2 && dia >= 1 && dia <= 29 ) && (ano % 400 == 0 || ano % 4 == 0) && (ano % 100 != 0))
                        {
                            
                        }

                    }
                    else
                    {
                        Console.WriteLine("Data Invalida");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
