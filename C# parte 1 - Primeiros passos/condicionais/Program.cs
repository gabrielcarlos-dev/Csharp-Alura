using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8 - Condicionais 2");

            int idadeJoao = 25;
            bool acompanhante = true;

            if (idadeJoao >= 18 && acompanhante == true)
            {
                Console.WriteLine("Authorized");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
            Console.ReadLine();
        }
    }
}
