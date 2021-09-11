using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Quiz1
{
    /// <summary>
    /// Bad encapsulation
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Person
    {
        private static int Counter = 0;
        public readonly string firstName; //should be private
        public readonly string lastName; // should be private

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            // this.Counter += 1
            Counter += 1;
        }

        public Person() : this("John", "Doe") //overloaded constructor
        {
        }

        public override string ToString()
        {
            return $"{Counter} {firstName} {lastName}";
        }
    }

    /// <summary>
    /// Teacher "is-a" Person
    /// Teacher "has-a" list of Students
    /// Teacher is sealed so it cannot be a base class
    /// </summary>
    public sealed class Teacher : Person
    {
        private readonly IEnumerable<Person> _students;

        public Teacher(IEnumerable<Person> students, string firstname, string lastname) : base(firstname, lastname)
        {
            _students = students;
        }

        public override string ToString()
        {
            return $"{base.ToString()} has {_students.Count()} students";
        }
    }

    /// <summary>
    /// Will not compile because Teacher is sealed
    /// </summary>
    // public class TeacherAssistant : Teacher
    // {
    //     //TODO: implementation
    // }
}
