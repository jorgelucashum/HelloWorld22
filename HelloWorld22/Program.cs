using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Expressão condicional ternária:
            // Estrutura opcional ao if-else quando se deseja decidir um valor com base em uma condição.
            // Ex:  ( condição ) ? valor_se_verdadeiro : valor_se_falso

            Console.WriteLine("Digite o valor do produto: ");
            double preco = double.Parse(Console.ReadLine());

            double desconto = (preco < 20) ? preco * 0.10 : preco * 0.05; // Expressão condicional ternária que substitui o if-else.

            Console.WriteLine("Valor do desconto: " + desconto);


            Console.ReadLine();
        }
    }
}
