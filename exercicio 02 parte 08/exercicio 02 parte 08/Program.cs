using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02_parte_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite um numero.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero.");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero.");
            c = int.Parse(Console.ReadLine());

            if (a > (b + c))
            {
                Console.WriteLine(a +" é maior que"+ b +" + "+ c);
            }
           
        }
    }
}
