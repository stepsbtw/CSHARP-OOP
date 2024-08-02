namespace Overloading
{
    static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static string Add(string a, string b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(1,2));
            Console.WriteLine(Calculator.Add("caio", "joao"));
            Console.WriteLine(Calculator.Add(0.5f, 0.4f));
            Console.WriteLine(Calculator.Add(0.5, 0.4));
        }
    }
}