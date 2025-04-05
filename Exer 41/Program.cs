using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_41
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Informe seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");
            altura = double.Parse(Console.ReadLine());  

            imc = peso / Math.Pow(altura, 2);

            if(imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc > 18.6 && imc <= 24.9)
            {
                Console.WriteLine("Saudável");
            }
            else if (imc > 25.0 && imc <= 29.9)
            {
                Console.WriteLine("Peso em excesso");
            }
            else if (imc > 30.0 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau 1");
            }
            else if (imc > 35.0 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade Grau 2 (severa)");
            }
            else if (imc >= 40.0)
            {
                Console.WriteLine("Obsidade Grau 3 (mórbida)");
            }
            Console.ReadLine();
        }
    }
}
