using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            double inves = 1000;
            for (int contMes = 1; contMes <= 12; contMes++)
            {
                inves *= 1.0036;
                Console.WriteLine("Após " + contMes + " você terá R$ " + inves);
            }
            Console.ReadLine();
        }
    }
}
