using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um Número: ");
            n = int.Parse(Console.ReadLine());
            if (n >= 20 && n <= 100) { Console.WriteLine("O Número " + n + " está entre 20 e 100."); }
            else {Console.WriteLine("O Número " + n + " não está entre 20 e 100."); }
            Console.ReadKey();
        }
    }
}
