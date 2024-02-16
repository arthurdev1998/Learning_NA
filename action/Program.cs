using action;

List<Product> list = new List<Product>();
list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));


// Action<Product> act = p => {p.Price = p.Price * 1,10;};

list.ForEach(x => {x.Price = x.Price * 1.10;});

foreach(var item in list)
{
    Console.WriteLine(item.Price);
}


Func<Product, string> func = x => x.Name.ToUpper();

var novalista = list.Select(func).ToList();
var novalista1 = list.Select(x => x.Name.ToUpper());