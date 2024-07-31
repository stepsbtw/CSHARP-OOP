namespace ex4
{
    interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        public double radius { get; set; }
        public double CalculateArea()
        {
            return Math.PI * 2 * this.radius;
        }
    }

}