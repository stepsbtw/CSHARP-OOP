using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        ListTest();
    }
    static void StringTest()
    {
        string[] nomes = { "Caio", "Joao", "renato" };
        Strings.Teste1(nomes);
        Strings.Teste2(nomes[0]);
        Strings.Teste3(nomes[0]);
        Strings.Teste4();
    }

    static void ListTest()
    {
        Lists.Teste1();
    }
}