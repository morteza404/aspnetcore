using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var obj1 = new Result<int, string> {id=1, prop1=20, prop2="ali" };
            var obj2 = new Result<string, bool> { id = 2, prop1 = "reza", prop2 = true };
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
    class Result<T,U>
    {
        public int id { get; set; }
        public T prop1 { get; set; }
        public U prop2 { get; set; }
    }
}
