using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_fluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7 - Condicionais e controle de fluxo");

            int idadeJoao = 25;
            int acompanhante = 1;

            if (idadeJoao > 18)
            {
                Console.WriteLine("Idade maior que 18");
            }
            else
            {
                if (acompanhante == 2)
                {
                    Console.WriteLine("Idade menor que 18, com acompanhante.");
                }
                Console.WriteLine("Idade menor que 18 e sem acompanhante");
            }

            Console.ReadLine();
        }
    }
}
