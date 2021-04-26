using System;

namespace DelegateApp02
{
    delegate void MyDelegate();

    delegate void MyDelegate2(string name);

    delegate void MyDelegate3(int num);

    delegate int MyDelegate4(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = SayHello;
            del();
            Test(del);

            MyDelegate2 del2 = Test2;
            del2("Saeed");

            MyDelegate3 del3 = Test3;
            del3(20);

            MyDelegate4 del4 = Test4;
            int result = del4(20,4);
            Console.WriteLine(result);


        }
        static void SayHello()
        {
            Console.WriteLine("Hey There!");
        }

        static void Test(MyDelegate del)
        {
            del();
        }

        static void Test2(string name)
        {
            Console.WriteLine("Hello {0} !", name);
        }
        static void Test3(int num)
        {
            Console.WriteLine("{0} * 3 = {1} !", num, num * 3);
        }

        static int Test4(int a, int b)
        {
            return a * b;
        }
    }
}
