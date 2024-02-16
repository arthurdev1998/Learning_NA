namespace DelegateLambda;

delegate double BinaryNumericOperation(double n1, double n2);


public class Product /*: IComparable<Product>*/
{
    public string? Name { get; set; }
    public double Price { get; set; }

    // public int CompareTo(Product other)
    // {
    //     return Name.ToUpper().CompareTo(other?.Name?.ToUpper());
    // }

    public override string ToString()
    {
        return $"name: {Name}  Preço:{Price}";
    }
}