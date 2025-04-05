using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;

            Console.WriteLine("Informe a sua data de nascimento");
            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            ano = int.Parse(Console.ReadLine());
            // ciar um booleano para bissexto e um para validar a data para não gerar erro no if e else
            bool bissexto = (ano % 400 == 0 || ano % 4 == 0) && (ano % 100 != 0);
            bool datavalida = false;

            if (mes == 2)
            {
                if ((bissexto && dia > 0 && dia <= 29) || (!bissexto && dia > 0 && dia < 28))
                {
                    datavalida = true;
                }


            }
            else if (mes == 04 || mes == 06 || mes == 09 || mes == 11 || dia > 0 || dia <= 30)
            {
                if (ano > 1900 && ano < 2026)
                {
                    datavalida = true;
                }

                else if (mes == 01 || mes == 03 || mes == 05 || mes == 07 || mes == 08 || mes == 10 || mes == 12 || dia > 0 && dia <= 31)
                {
                    if (ano > 1900 && ano < 2026)
                    {
                        datavalida = true;
                    }
                }
            }
            if (datavalida)
            {
                Console.WriteLine("data valida");
            }
            else
            {
                Console.WriteLine("data invalida");
            }
            Console.ReadLine();
            
        }
    }
}

            
            
        
    

