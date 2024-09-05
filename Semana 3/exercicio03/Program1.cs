using System;
using System.ID;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "arquivo.txt";
            string texto = "Doc de texto";

            File.WriteAllText(nomeDoArquivo, texto);

            Console.WriteLine("Arquivo criado");

            Console.ReadKey(true);
        }
    }
}