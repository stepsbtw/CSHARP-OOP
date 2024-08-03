using System;
namespace Objects
{
    class Jgk
    {
        public string Nome;
        private int id;
        
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }
    }
    class Jgk2
    {
        public string Nome;
        public int Id { get; private set; }
    }
    
    class Principal
    {
        static void Main()
        {
            Jgk jgk = new Jgk();
            jgk.Nome = "jgk";
            // mesma coisa
            Jgk caio = new Jgk() { Nome = "Caio" };

            jgk.setId(123);
            Console.WriteLine("id do seu jgk: " + jgk.getId());

            Jgk2 jgk2 = new Jgk2() { Nome = "jgk" };
            Console.WriteLine(jgk2.Id);
            // jgk2.Id = 123; o SET default é PRIVADO. NAO PODE.
            
        }
    }
}
