using System.Collections;
using System.Runtime.CompilerServices;

class Lists
{
    public static void Teste1()
    {
        //string[] s = new string[5];
        List<string> stringList = new List<string>();
        stringList.Add("Joao");
        stringList.Add("Renato");
        foreach(string str in stringList)
            Console.WriteLine(str);
        Console.WriteLine(stringList.Count);
    }
    public static void Teste2()
    {
        LinkedList<string> stringLinkedList = new LinkedList<string>();
        stringLinkedList.AddLast("Caio");
        stringLinkedList.AddFirst("Joao");
        stringLinkedList.RemoveFirst();
        stringLinkedList.AddFirst("Caio");
        stringLinkedList.Remove("Caio");
    }

}