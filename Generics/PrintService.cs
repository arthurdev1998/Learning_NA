namespace Generics;

public class PrintService<T> where T : IComparable
{
    List<T> lista = new List<T>();

    public void add(T valor)
    {
        lista.Add(valor);
    }

    public void First()
    {
        Console.WriteLine(lista.First());
    }

    public void Print()
    {
        lista.ForEach(x => Console.WriteLine(x));
    }
}