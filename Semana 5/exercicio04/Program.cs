using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace AsyncAwaitDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string URL = "https://raw.githubusercontent.com/l3oxer/Doggo/main/README.md";

            Stopwatch sw = new Stopwatch();
            
            sw.Start();
            var tasks = new List<Task> { SummonDogLocally(), SummonDogFromUrl(URL)};
            await Task.WhenAll(tasks);
            sw.Stop();

            Console.WriteLine("We are done here... " + sw.Elapsed);
        }

        static async Task SummonDogLocally()
        {
            Console.WriteLine("1. Summoning Dog Locally ...");

            string dogText = await File.ReadAllTextAsync("dog.txt");

            Thread.Sleep(1000);            

            Console.WriteLine($"2. Dog Summoned Locally \n{dogText}");
        }

        // static async Task<string> SummonDogLocally()
        // {
        //     Console.WriteLine("1.Summoning Dog Locally ...");

        //     string dogText = await File.ReadAllTextAsync("dog.txt");

        //     Console.WriteLine($"2. Dog Summoned Locally \n{dogText}");

        //     return dogText;
        // }
    
        static async Task SummonDogFromUrl(string URL)
        {
            Console.WriteLine("1. Sumonning Dog from URL ...");

            using(var httpClient = new HttpClient())
            {
                string result = await httpClient.GetStringAsync(URL);
                Console.WriteLine($"2. Dog Summoned from URL \n{result}");
            }

        }
    }
}