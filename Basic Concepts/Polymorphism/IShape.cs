using System;
namespace Polymorphism
{
    interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
        public double CalculateArea()
        {
            return Math.PI * 2 * this.Radius;
        }
    }

    public class Rectangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double CalculateArea()
        {
            return this.Base * this.Height;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Rectangle rect = new Rectangle { Base = 10, Height = 20 };
            Circle circ = new Circle { Radius = 10 };

            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(circ.CalculateArea());
        }
    }


}