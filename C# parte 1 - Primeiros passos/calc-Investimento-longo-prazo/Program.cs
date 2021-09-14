using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_Investimento_longo_prazo
{
    class Program
    {
        static void Main(string[] args)
        {
            double invest = 1000;
            double fatInv = 1.0036;

            for (int contAno = 1; contAno <= 5; contAno++){
                for (int contMes = 1; contMes <= 12; contMes++)
                {
                    invest *= fatInv;
                }
                fatInv += 0.001;
            }
            Console.WriteLine("ao termino do investimento o patrimônio é de " + invest);
            Console.ReadLine();
        }
    }
}
