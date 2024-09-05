using System;
using System.ID;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] documentos = {"documento 1.", "documento 2."};
            string nomeDoArquivo = "documentos.txt";

            File.WriteAllText(nomeDoArquivo, documentos);



            Console.WriteLine("Arquivo criaddo");

            Console.ReadKey(true);
        }
    }
}