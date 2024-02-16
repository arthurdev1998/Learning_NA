// See https://aka.ms/new-console-template for more information
using System.Reflection;
using LinqExercicios;

Console.WriteLine("Hello, World!");
 
 // Ler um arquivo csv em seguida mostrar o preço médio dos produtos
 // depois mostrar os nomes em ordem decrescente dos produtos que possuem preço inferior ao preço medio

 Console.WriteLine("Digite o caminho do arquivo");
 var path = Console.ReadLine();

List<Producs> products = new List<Producs>();

using(StreamReader sr = File.OpenText(path))
{
    while(!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');
        var name = fields[0];
        var price = double.Parse(fields[1]);

        products.Add(new Producs{Name = name, Price = price});
    }

    var precoMedio = products.Select(x => x.Price).DefaultIfEmpty(0.0).Average();

    var precosNovos = products.Where(x => x.Price < precoMedio).OrderByDescending(x => x.Name).Select(x => x.Name).ToList();

    precosNovos.ForEach(x => Console.WriteLine(x));
}