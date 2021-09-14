using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharAndText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 - Caracteres e texto.\n");

            char caractere = 'a'; //Aspas simples somente para caracteres (unicos)
            string text =
@"-Lorem
-Ipsum
-Dolor"; //Aspas duplas para Text //@"" - usado para considerar quebras de linha, espaços e parágrafos

            Console.WriteLine("caractere: "+ caractere);
            Console.WriteLine("\ntext: " + text);

            Console.ReadLine();
        }
    }
}
