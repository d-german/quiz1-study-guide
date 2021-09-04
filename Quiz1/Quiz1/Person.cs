using System.Diagnostics.CodeAnalysis;

namespace Quiz1
{
    /// <summary>
    /// Bad encapsulation
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Person
    {
        public readonly string firstName; //should be private
        public readonly string lastName; // should be private

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person() : this("John", "Doe") //overloaded constructor
        {
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
