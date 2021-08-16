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
            double numero1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite outro número!");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado = numero1 + numero2;
            Console.WriteLine("O resultado da soma é: " + resultado + "!");

            double resultado1 = numero1 - numero2;
            Console.WriteLine("O resultado da subtração é: " + resultado1 + "!");

            double resultado2 = numero1 * numero2;
            Console.WriteLine("O resultado da multiplicação é: " + resultado2 + "!");

            double resultado3 = numero1 / numero2;
            Console.WriteLine("O resultado da divisão é: " + resultado3 + "!");

            //Console.WriteLine("A soma entre os números escolhidos é: " + som + "!"
            //    + "\nA subtração entre os números escolhidos é: " + sub + "!"
            //    + "\nA multiplicação entre os números escolhidos é: " + mult + "!"
            //    + "\nA divisão entre os números escolhidos é: " + divi + "!");

            Console.ReadKey();
        }
    }
}
