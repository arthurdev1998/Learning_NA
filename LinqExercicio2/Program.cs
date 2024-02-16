// See https://aka.ms/new-console-template for more information
using System.Globalization;
using LinqExercicio2;

Console.WriteLine("Hello, World!");

// ler os dados do (nome, email e salario)
// mostrar em ordem alfabetica o email dos funcionarios cujo salario seja superior 
// a um dado valor fornecido pelo usuario.

// mostrar também a soma dos salários dos funcionários cujo nome começa com a letra 'M'


Console.Write("Enter full file path: ");
string path = Console.ReadLine();

Console.Write("Digite um salario");
double salario = double.Parse(Console.ReadLine());

List<Employee> lista = new();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');
        string name = fields[0];
        string EmailEmployee = fields[1];
        double salarioEmployee = double.Parse(fields[2], CultureInfo.InvariantCulture);
        lista.Add(new Employee { Name = name, Email = EmailEmployee, Salario = salarioEmployee });
    }

    var Empregados = lista.Where(x => x.Salario > salario).OrderBy(x => x.Name).Select(x => x.Email).ToList();
    Empregados.ForEach(x => Console.WriteLine(x));

    var funcionariosWithM = lista.Where(x => x.Email.StartsWith('M')).Select(x => x.Salario).Sum();
    Console.WriteLine(funcionariosWithM);
}