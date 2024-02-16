namespace LINQ1;

public class Categoria
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Tier { get; set; }

    public override string ToString()
    {
        return $": {Name}";
    }
}