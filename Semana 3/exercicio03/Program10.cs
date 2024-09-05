using System;
using System.ID;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] arquivos = Directory.GetFiles(@"C:\");

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }


            Console.ReadKey(true);
        }
    }
}