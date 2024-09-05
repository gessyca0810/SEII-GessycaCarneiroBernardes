using System;
using System.ID;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string diretorio = "pasta";

            if(Directory.Exists(diretorio))
            {
            Console.WriteLine("existe");
            }
            
            else
            {
            Console.WriteLine("não existe");

            }


            Console.ReadKey(true);
        }
    }
}