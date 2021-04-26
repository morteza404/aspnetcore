using System;
using System.Reflection;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine("Type : " + type.Name + "BaseType: " + type.BaseType);

                var props = type.GetProperties();

                foreach (var prop in props)
                {
                    Console.WriteLine("\tProperty : " + prop.Name);
                }

                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    Console.WriteLine("\tField : " + field.Name);
                }

                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("\tMethod : " + method.Name);
                }
            }

            var sample = new Sample { Name = "John", Age = 25};

            var sampleType = typeof(Sample);

            var nameProperty = sampleType.GetProperty("Name");

            Console.WriteLine("Property : " + nameProperty.GetValue(sample));

            var myMethod = sampleType.GetMethod("MyMethod");

            myMethod.Invoke(sample, null);


        }
    }

    public class Sample
    {
        public string Name { get; set; }

        public int Age;

        public void MyMethod()
        {
            Console.WriteLine("Hello from MyMethod");
        }
    }
}
