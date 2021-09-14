using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 - Criando variaveis ponto flutuante.");
            double var;
            var = 11.4;

            Console.WriteLine(var);

            var = 11.0 / 5;
            Console.WriteLine("11.0 / 5 = " + var);

            Console.WriteLine("A execução terminou. Tecle Enter para sair. . .");
            Console.ReadLine();
        }
    }
}
