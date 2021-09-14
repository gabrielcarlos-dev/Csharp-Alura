using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int var;
            var = 10;

            Console.WriteLine("var = " + var);

            var = (10 + 10) * 20;

            Console.WriteLine("var = " + var);

            Console.WriteLine("A execução terminou. Tecle Enter para sair. . .");
            Console.ReadLine();
        }
    }
}
