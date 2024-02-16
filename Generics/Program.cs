using Generics;

Console.WriteLine("Digite a quantidade de vezes que vc quer preencher a lista");
var valor = int.Parse(Console.ReadLine());

PrintService<string> printService = new PrintService<string>();

for(int i =0 ; i< valor; i++)
{
    var valorKey = Console.ReadLine();
    printService.add(valorKey);
}

printService.First();
printService.Print();