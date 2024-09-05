using System;
using System.ID;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "documentos.txt";
            string conteudo = File.ReadAllLines(nomeDoArquivo);

            Console.WriteLine("Conteudo: ");
            Console.WriteLine(conteudo);
            Console.WriteLine("\n");

            File.AppendAllText(nomeDoArquivo, "Um outro arquivo");

            conteudo = File.ReadAllText(nomeDoArquivo);
            Console.WriteLine(conteudo);
            Console.WriteLine("\n");
            
            Console.ReadKey(true);
        }
    }
}