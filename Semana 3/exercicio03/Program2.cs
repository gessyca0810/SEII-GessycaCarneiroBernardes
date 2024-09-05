using System;
using System.ID;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string arquivo = "arquivo.txt";
            string texto = File.ReadAllText(arquivo);


            Console.WriteLine("Arquivo:" + texto);

            Console.ReadKey(true);
        }
    }
}