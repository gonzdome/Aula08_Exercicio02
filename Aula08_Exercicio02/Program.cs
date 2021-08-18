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

            resultado = numero1 - numero2;
            Console.WriteLine("O resultado da subtração é: " + resultado + "!");

            resultado = numero1 * numero2;
            Console.WriteLine("O resultado da multiplicação é: " + resultado + "!");

            resultado = numero1 / numero2;
            Console.WriteLine("O resultado da divisão é: " + resultado + "!");

            Console.ReadKey();
        }
    }
}
