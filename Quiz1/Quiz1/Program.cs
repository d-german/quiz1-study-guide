using System;
using System.Collections.Generic;

namespace Quiz1
{
    internal static class Program
    {
        private static void Main()
        {
            var student1 = new Person("StudentOneFirstName", "StudentOneLastName");
            var student2 = new Person("StudentTwoFirstName", "StudentTwoLastName");
            var student3 = new Person("StudentThreeFirstName", "StudentThreeLastName");
            var students = new List<Person> { student1, student2, student3 };

            students.Remove(student1);

            Console.WriteLine(new Person());
            Console.WriteLine(new Person("Mary", "Jane"));

            Console.WriteLine(new Teacher(students, "Sam", "Wise"));

            // Console.WriteLine(Adder.Add(2.0, 3.1));
            // Console.WriteLine(Adder.Add("Hello ", "World"));
            // Console.WriteLine(Adder.Add(2, 3));
        }
    }
}
