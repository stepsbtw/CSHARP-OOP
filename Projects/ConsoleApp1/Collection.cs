using System;
using System.Collections;
using System.Collections.Generic;
class Collection
{
    public static void Teste1()
    // A List é um array dinamico.
    // acesso O(1) indexado, adicionar O(1), inserir e remover O(n)
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
    // LinkedList duplamente encadeada.
    // acesso O(n), mas inserir e remover O(1) dado o nó.
    {
        LinkedList<string> stringLinkedList = new LinkedList<string>();
        stringLinkedList.AddLast("Caio");
        stringLinkedList.AddFirst("Joao");
        stringLinkedList.RemoveFirst();
        stringLinkedList.AddFirst("Caio");
        stringLinkedList.Remove("Caio");
    }

    public static void Teste3()
    {
        // DIFERENTE DE JAVA.
        // Nao é uma funcao generica. É sempre fracamente tipada.
        // Nao pertence ao System.Collections.Generic
        ArrayList ArrayList = new ArrayList();
        // A ArrayList foi adicionada antes de existir as colecoes genericas na linguagem.
    }

    public static void Teste4()
    // HASH: indentificador unico. SET: conjunto, elementos distintos.
    // Na média O(1).
    {
        HashSet<string> stringSet = new HashSet<string>();
        stringSet.Add("caio");
        stringSet.Add("Caio");
        stringSet.Add("caio");
        Console.WriteLine(stringSet);
        foreach(string s in stringSet)
            Console.WriteLine(s);

        Console.WriteLine(stringSet.Contains("joao"));
    }

    public static void Teste5()
    {
        Dictionary<float,string> stringDict = new Dictionary<float,string>();
        stringDict.Add(0, "caio");
        stringDict.Add(0f, "joao");
        stringDict.Add(2.5f, "renato");
        Console.WriteLine(stringDict);
        foreach (string s in stringDict.Values)
            Console.WriteLine(s);

        foreach(float f in stringDict.Keys)
            Console.WriteLine(f);

    }
}