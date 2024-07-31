class Strings
{
    public static void Teste1(string[] nomes) // various methods
    {
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
            if (nome.EndsWith('o'))
                Console.WriteLine($"{nome} é masculino");

            if (nome.StartsWith('C'))
                Console.WriteLine("Comeca com C!");

            if (nome[0] > 64 && nome[0] <= 90)
                Console.WriteLine("Maiúscula!");
            else
                Console.WriteLine("Minúscula!");


        }
    }

    public static void Teste2(string s) // more methods
    {
        Console.WriteLine(s.Length);

        if (s.Contains('a'))
        {
            Console.WriteLine("possui a letra a!");
            Console.WriteLine("na posicao : " + s.IndexOf('a'));
        }

        if (s.Contains("ao"))
            Console.WriteLine($"possui \"ao\" na posicao {s.IndexOf("ao")}");

        if (s.Contains('a') && s.Contains('o'))
            Console.WriteLine("possui a e o");
    }
    
    public static void Teste3(string s) // case sensitivity
    {
        if (string.Equals(s.ToLower(), s.ToUpper()))
            Console.WriteLine("diferente");

        if (string.Equals(s.ToLower(), s.ToUpper(), StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("igual!");
    }

    public static void Teste4()
    {
        string s = Console.ReadLine();
        Console.WriteLine(string.IsNullOrEmpty(s));
        Console.WriteLine(string.IsNullOrWhiteSpace(s));
    }
}