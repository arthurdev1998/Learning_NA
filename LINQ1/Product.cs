namespace LINQ1;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public Categoria Categoria{ get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, $Preco :{Price}, Categoria {Categoria}";
    }
}