/*public delegate bool Predicate<in T>(T obj); */


using Predicate;

List<Product> list = new List<Product>();
list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

list.RemoveAll(x => x.Price >= 100);
foreach (var item in list)
{
    Console.WriteLine(item);
}

// OU

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

list.RemoveAll(ProductVerify);

static bool ProductVerify(Product p)
{
    return p.Price >= 100;
}

foreach (var item in list)
{
    Console.WriteLine(item);
}

