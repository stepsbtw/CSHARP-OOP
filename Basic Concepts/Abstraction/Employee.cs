using System;

namespace Abstraction
{
    // never instantied.
    public abstract class Employee
    {
        // ABSTRACT METHODS ONLY ON ABSTRACT CLASSES
        private string name;
        private int id;
        public string Email;
        // its not public for getting anymore.

        // but can have a constructor.
        public Employee(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public abstract float CalculateSalary();
    }
    
    public class FullTimeEmployee : Employee
    {
        // the constructor is INHERITED!
        public FullTimeEmployee(string name, int id) : base(name,id)
        {
            // base(name, id);
            // does not work like java.
        }

        // implementing abstract methods => override
        public override float CalculateSalary()
        {
            return 0;
        }
    }
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name, int id, float any) : base(name,id)
        {
            // does not need the same signature.
        }
        public override float CalculateSalary()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main()
        {
            // WITH CONSTRUCTORS DEFINED, THE DEFAULT DOES NOT WORK.

            //FullTimeEmployee e1 = new FullTimeEmployee { name = "Caio", id = 28938};
            //PartTimeEmployee e2 = new PartTimeEmployee { name = "Joao", id = 12318 };

            FullTimeEmployee e1 = new FullTimeEmployee("Caio", 123) { Email = "blabla@gmail.com" };
            }
    }
}
