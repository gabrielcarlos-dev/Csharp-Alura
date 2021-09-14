using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atribuindo_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = num1;

            num1 = 2;
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);

            Console.ReadLine();
        }
    }
}
