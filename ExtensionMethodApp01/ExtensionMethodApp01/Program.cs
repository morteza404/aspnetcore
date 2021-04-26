using System;

namespace ExtensionMethodApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Name="John", Age=25};
            var p2 = new Person { Name = "Sally", Age = 25 };
            p.SayHello(p2);

        }
    }

    public static class Extensions
    {
        public static void SayHello(this Person person, Person person2)
        {
            Console.WriteLine("{0} Says Hello.", person.Name, person.Name);
        }
    }
}
