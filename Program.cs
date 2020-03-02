using System;
using System.Threading;

namespace threading_corert
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(WriteInLoop);
            Thread thread2 = new Thread(WriteInLoop);
            Console.WriteLine("Hello World!");
            thread1.Start(1);
            Thread.Sleep(500);
            thread2.Start(2);
        }

        public static void WriteInLoop(object state)
        {
            int thread_id = (int)state;
            Console.WriteLine($"From thread {thread_id}");
        }
    }
}
