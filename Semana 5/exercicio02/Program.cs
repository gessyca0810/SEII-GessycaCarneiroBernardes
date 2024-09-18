using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ProgAssincrona
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ExectuarComTasks();
            sw.Stop();
            Console.WriteLine($"Operação gastou {sw.ElapsedMilliseconds} milisegundos.");
        }


        static void RealizarOperacao (int op, string nome, string sobrenome)
        {
            Console.WriteLine($"Iniciando operação {op}...");
            for (int i = 0; i < 100000000; i++)
            {
                var p = new Pessoa(nome, sobrenome, 40);
            }
            Console.WriteLine($"Finalizando operação {op}...");
        }

        static void ExecutarSequencial()
        {
            RealizarOperacao(1, "Gessyca", "Carneiro");
            RealizarOperacao(2, "Eduardo", "dos Santos");
            RealizarOperacao(3, "Pedro", "Antônio");
        }

        static void ExectuarComThreads()
        {
            var t1 = new Thread(() => 
            {
                RealizarOperacao(1, "Gessyca", "Carneiro");
            });
            var t2 = new Thread(() =>
            {
                RealizarOperacao(2, "Eduardo", "dos Santos");
            });
            var t3 = new Thread(() =>
            {   
                RealizarOperacao(3, "Pedro", "Antônio");
            });

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }

        static void ExectuarComTasks()
        {
            var t1 = Task<int>.Run(() => 
            {
                RealizarOperacao(1, "Gessyca", "Carneiro");
                return 1;
            });
            var t2 = Task<int>.Run(() =>
            {
                RealizarOperacao(2, "Eduardo", "dos Santos");
                return 2;
            });
            var t3 = Task<int>.Run(() =>
            {   
                RealizarOperacao(3, "Pedro", "Antônio");
                return 3;            
            });
            Console.WriteLine($"Tarefa {t1.Result} finalizou.");
            Console.WriteLine($"Tarefa {t2.Result} finalizou.");
            Console.WriteLine($"Tarefa {t3.Result} finalizou.");
        }

    }
    
}