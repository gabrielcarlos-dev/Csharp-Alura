using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //1ª resolução
            Console.WriteLine("1ª resolução");
            string star = "*";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }

            //2ª resolução
            Console.Write("\n2ª resolução");
            for (int contRow = 0; contRow <= 5; contRow++)
            {
                for (int contCol = 0; contCol < contRow; contCol++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
