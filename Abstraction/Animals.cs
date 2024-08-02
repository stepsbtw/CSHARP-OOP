using System;

namespace Animals
{
    public abstract class Animal
    {
        // have default behavior.
        // optional implementation
        public virtual void MakeSound()
        {
            Console.WriteLine("sound is:");
        }

        // dont have any default behavior, must be implemented.
        // abstract method ONLY inside abstract class.
        public abstract void MakeSoundAbs();
    }

    public class Dog : Animal
    {

        /*
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("auau");
        }
        */

        // if not implemented, compiler error
        public override void MakeSoundAbs()
        {
            Console.WriteLine("auau");
        }
    }
    
}
