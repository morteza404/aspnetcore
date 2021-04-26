using System;
using System.Linq;
using System.Reflection;

namespace ReflectionApp02
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyClassAttribute>().Count() > 0);

            foreach (var type in types)
            {
                Console.WriteLine(type.Name);

                var methods = type.GetMethods().Where(m => m.GetCustomAttributes<MyMethodAttribute>().Count() > 0);

                foreach (var method in methods)
                {
                    Console.WriteLine(method.Name);
                }
            }

        }
    }
    [MyClass]
    public class Sample
    {
        public string Name { get; set; }

        public int Age;
        [MyMethod]
        public void MyMethod()
        {
            Console.WriteLine("Hello From MyMethod!");
        }

        public void NoAttributeMethod() { }
    }
    [AttributeUsage(AttributeTargets.Class)]
    public class MyClassAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Method)]
    public class MyMethodAttribute : Attribute
    {

    }

}
