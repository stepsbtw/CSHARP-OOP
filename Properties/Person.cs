using System;
namespace Properties
{
    class Person
    {
        // 0 logic.
        private string name;
        
        // A CONTROLLED PROPERTY.
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            }
        }
    }
    class Program2
    {
        static void Main()
        {
            Person person = new Person()
            {
                Name = Console.ReadLine()
            };
        }
    }
}
