Console.WriteLine("Digite seu nome");
string name  = Console.ReadLine();
//Console.WriteLine("seu nome é : " + name);
Console.WriteLine($"Olá {name}!");

Console.WriteLine("Insira sua idade");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Insira sua altura");
float height = float.Parse(Console.ReadLine());

Console.WriteLine($"{name} possui {age} anos e {height} de altura.");
