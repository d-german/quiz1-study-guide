using System;

namespace Quiz1
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(new Person());
            Console.WriteLine(new Person("Mary", "Jane"));
            Console.WriteLine(Adder.Add(2.0, 3.1));
            Console.WriteLine(Adder.Add("Hello ", "World"));
        }
    }
}
