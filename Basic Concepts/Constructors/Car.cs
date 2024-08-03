using System;
namespace Destructors
{
    public class Car
    {
        private string model;
        private int year;

        public Car(string model, int year)
        {
            this.model = model;
            this.year = year;
        }

        // super rare, .NET GC already does the job.
        ~Car(){
            Console.WriteLine("carro destruido.");
        }

    }
    public class Program
    {
        static void Main()
        {
            // the default constructor is removed,
            // when a custom constructor is defined.
            //Car c1 = new Car();
            Car c1 = new Car("Honda", 2005);

        }
    }
}