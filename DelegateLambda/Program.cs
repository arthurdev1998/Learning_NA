using DelegateLambda;

var lista = new List<Product>
{
    new Product
    {
        Name = "kkkk",
        Price = 5
    },

    new Product
    {
        Name = "aaa",
        Price = 6
    },

    new Product
    {
        Name = "qqqq",
        Price = 7
    }
};

lista.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // método sort aceita a referencia da funcao

static int CompareTo(Product p1, Product p2)
{
    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
}

foreach (var product in lista)
{
    Console.WriteLine(product);
}

/////////////////////////////////////////////////////////////////////////
///
double a = 10;
double b = 12;

BinaryNumericOperation op = CalculationService.Sum;
op += CalculationService.Max;

op.Invoke(a, b);

delegate void BinaryNumericOperation(double n1, double n2);