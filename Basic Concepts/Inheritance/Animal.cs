using System;
namespace Inheritance
{
    public class Animal
    {
        // private by default
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine(Name + "is making sounds!");
        }
    }

    public class Dog : Animal
    {
        /*
        private string name;
        private int age;
        private string breed;
        */
        public override void MakeSound()
        {
            Console.WriteLine("bark bark woof woof");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("meow meow");
        }
        public void LandingOnFeet()
        {
            Console.WriteLine("cats always lands on their feet.");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog d1 = new Dog();
            Animal d2 = new Dog();
            // this one dont have dog only members.
            // it only can use whatever is common to all animals and dog.

            Animal myDog = new Dog();
            myDog.Age = 1;
            myDog.Name = "rex";

            Animal myCat = new Cat { Name = "bixo", Age = 3 };
            // in this case for ex. mycat doesnt have the landingonfeet method.
            // cause its type is ANIMAL.

            Cat c1 = new Cat { Name = "Felix", Age = 1 };
            c1.LandingOnFeet();

            myDog.MakeSound();
            myCat.MakeSound();
        
        }
    }
}