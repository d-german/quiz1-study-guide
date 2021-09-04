using System;
using System.Collections.Generic;

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
            Console.WriteLine(Adder.Add(2, 3));
            Console.WriteLine(new Teacher(new List<Person>(), "Sam", "Wise"));

        }
    }
}
