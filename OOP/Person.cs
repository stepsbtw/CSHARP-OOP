namespace ex1
{
    class Person
    {
        // by default, all members of a class are private.
        // and all members of a struct are public.
        string name;
        int age;
        string gender;
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setGender(string gender)
        {
            this.gender = gender;
        }
    }

    class Program
    {
        static void Main()
        {
            Person p1 = new Person();
            p1.setName("Caio");
            p1.setAge(19);
            p1.setGender("Unknown");

            Console.WriteLine(p1);
            // override the toString method.
        }
    }
}