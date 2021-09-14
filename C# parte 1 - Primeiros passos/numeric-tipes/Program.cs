using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeric_tipes
{
    class Program
    {
        static void Main(string[] args)
        {
            double numDouble;
            numDouble = 1.5;

            int numInt;
            numInt = (int)numDouble;//"(type)num" - usado para forçar a conversão da variável

            Console.WriteLine("numInt = " + numInt);

            short numShort; //suporta até 32bits
            numShort = 11111;
            Console.WriteLine("numShort = " + numShort);

            long numLong; //suporta variável até 64bits
            numLong = 1111111111111111111;
            Console.WriteLine("numLong = " + numLong);


            Console.WriteLine("A execução acabou. Tecle Enter para sair. . .");
            Console.ReadLine();
        }
    }
}
