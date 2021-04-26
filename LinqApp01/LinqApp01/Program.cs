using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = "i enjoy writing C#";

            foreach (var item in sample)
            {
                Console.WriteLine(item);
            }
        }
    }
}
