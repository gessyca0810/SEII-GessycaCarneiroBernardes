using System;
using System.ID;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "arquivo.txt";
            Console.WriteLine(File.Exists(nomeDoArquivo));
            
            File.AppendAllText(nomeDoArquivo, "Um outro arquivo");
            Console.WriteLine(File.Exists(nomeDoArquivo));


            Console.ReadKey(true);
        }
    }
}