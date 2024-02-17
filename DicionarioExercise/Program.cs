// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.Write("Enter full file path: ");
string path = Console.ReadLine();

Console.Write("Digite um salario");
double salario = double.Parse(Console.ReadLine());

Dictionary<string, int> votacao = new();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');
        if (votacao.ContainsKey(fields[0]))
        {
            votacao[fields[0]] += int.Parse(fields[1]);
        }
        else
        {
            votacao.Add(fields[0], int.Parse(fields[1]));
        }
    }
}