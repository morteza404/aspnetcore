using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParalellApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Task(() => DoSomeThing(1,1500));
            t1.Start();
            var t2 = new Task(() => DoSomeThing(2, 1500));
            t2.Start();
            var t3 = new Task(() => DoSomeThing(3, 1500));
            t3.Start();

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        static void DoSomeThing(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is beginning.", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} is completed.", id);
        }
    }
}
