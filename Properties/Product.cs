namespace Properties
{
    class Product
    {
        // Properties are ENCAPSULATED.
        // They help with Access Control.
        // Basic default properties are FUTURE PROOF.
        // Can be expanded later, without needing changes to API.

        public string ProductID {
            // i'm defining a property.
            get;
            set;
        }
        public string ProductName { get; set; }
        // this get;set; is just the default implementation
        public double Price { get; set; } 

        // READ-ONLY property:
        public double DiscountPrice
        {
            // THIS IS NOT A METHOD. is a property.
            get { return Price * 0.9; }
        }
    }
    class Program
    {
        static void Main2()
        {
            // initializing properties dont need a constructor.
            Product p1 = new Product()
            {
                ProductID = "123",
                ProductName = "caio",
                Price = 1000.0
                //DiscountPrice dont work, there is not a set.
            };
            Console.WriteLine(p1.DiscountPrice);
        }
    }
}