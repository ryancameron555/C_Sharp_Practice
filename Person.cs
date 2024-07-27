using System;

namespace CSharpCrash
{
    public class Person
    {
        //fields
        private string name;
        private int age;

        //constructors
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Properties (accessors for private fields)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // ALTERNATIVE: If you don't want to initialize the fields via constructor arguments, you can also
        // directly set property values. Just set person.Age or person.Name in the calling class / function
        // public string? Name { get; set; }
        // public int? Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}. I am {Age} years old.");
        }
    }
}
