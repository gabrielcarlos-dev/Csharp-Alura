using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_poupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            double invest = 1000;
            int contMes = 1;
            while (contMes <= 12) {
                invest = invest + invest * 0.0036;
                Console.WriteLine("Após " + contMes + " você terá R$: " + invest);

                contMes++;
            } 

            Console.ReadLine();
        }
    }
}
