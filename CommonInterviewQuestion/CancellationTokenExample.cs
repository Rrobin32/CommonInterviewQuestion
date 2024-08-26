using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class CancellationTokenExample
    {
        public static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken cancellationToken = cts.Token;

            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };

            Thread t2 = new Thread(() => LongRunningThread(cancellationToken));
            t2.Name = "Thread2";

            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };

            t1.Start();
            t2.Start();            
            t3.Start();
            cts.CancelAfter(100);
        }

        static void Method1()
        {
            Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
            Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
        }

        static void Method2()
        {
            
        }
        static void Method3()
        {
            Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
            Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
        }

        static void LongRunningThread(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine("Method2 :" + i);
                        if (i == 3)
                        {
                            Console.WriteLine("Performing the Database Operation Started");
                            //Sleep for 10 seconds
                            Thread.Sleep(10000);
                            Console.WriteLine("Performing the Database Operation Completed");
                        }
                    }
                    Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
                }
            }
            catch (OperationCanceledException)
            {
                // Handle cleanup or specific logic
            }
        }

    }
}
