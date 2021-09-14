using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int result = 1;

            Console.WriteLine("Fatorial de !" + num);
            for (num = num; num > 1; num--)
            {
                Console.Write(num + " * ");
                result *= num;
            }
            Console.WriteLine("1 = " + result);

            Console.ReadLine();
        }
    }
}
