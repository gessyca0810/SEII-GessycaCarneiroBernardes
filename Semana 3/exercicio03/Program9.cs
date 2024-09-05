using System;
using System.ID;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string diretorio = "pasta";
            Directory.Delete(diretorio);

            Console.ReadKey(true);
        }
    }
}