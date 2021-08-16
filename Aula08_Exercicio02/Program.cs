using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //soma, subtração, multiplcação e divisão

            Console.WriteLine("Digite um número!");
            double n1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite outro número!");
            double n2 = double.Parse(Console.ReadLine());

            double som = n1 + n2;
            double sub = n1 - n2;
            double mult = n1 * n2;
            double divi = n1 / n2;

            Console.WriteLine("A soma entre os números escolhidos é: " + som + "!"
                + "\nA subtração entre os números escolhidos é: " + sub + "!"
                + "\nA multiplicação entre os números escolhidos é: " + mult + "!"
                + "\nA divisão entre os números escolhidos é: " + divi + "!");

            Console.ReadKey();
        }
    }
}
