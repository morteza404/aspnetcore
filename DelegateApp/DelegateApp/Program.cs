using System;

namespace DelegateApp
{
    delegate void Operation(int num);
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = Double;
            op(2);
        }
        static void Double(int num)
        {
            Console.WriteLine("{0} * 2 = {1}", num, num * 2 );
        }
    }
}




