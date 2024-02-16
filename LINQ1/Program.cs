// See https://aka.ms/new-console-template for more information
using LINQ1;

Console.WriteLine("Hello, World!");

static void Print<T>(IEnumerable<T> colecao)
{
    colecao.ToList().ForEach(x => Console.WriteLine(x));
}


int[] dataSource = {1,2,3,4,5,6,7,89};

var novosDados = dataSource.Where(x => x %2 == 0).Select(x => x*10).ToList();

novosDados.ForEach(x => Console.WriteLine(x));
///////////////////////////////////////////
///

Categoria c1 = new Categoria{Id = 1 , Name = "Tools", Tier = 1};
Categoria c2 = new Categoria{Id = 2 , Name = "brinquedo", Tier = 2};
Categoria c3 = new Categoria{Id = 3 , Name = "Ferramenta", Tier = 3};

List<Product> products = new List<Product>
{
    new Product{Name = "Computer", Price = 40, Categoria = c1},
    new Product{Name = "Laasmpssdsaada", Price = 480, Categoria = c2},
    new Product{Name = "asdasd", Price = 900, Categoria = c1},
    new Product{Name = "wwffd", Price = 100, Categoria = c2},
    new Product{Name = "adasd", Price = 444, Categoria = c3},
    new Product{Name = "sxxxx", Price = 2, Categoria = c1},
    new Product{Name = "Bonzzxeca", Price = 10004, Categoria = c3},
    new Product{Name = "vdd", Price = 2000, Categoria = c3},
    new Product{Name = "Boereneqweca", Price = 4623, Categoria = c2},
    new Product{Name = "tffff", Price = 444870, Categoria = c3},
};

// mostrar os que contem tier 1 e preço menor que 900

var novaLista = products.Where(x => x.Categoria.Tier == 1 && x.Price < 900).ToList();
novaLista.ForEach(x => Print(novaLista));

// Somente o nome dos produtos da categoria Tools

var novalista1 = products.Where(x => x.Categoria.Name.Equals("Tools")).Select(x => x.Name);
Print(novalista1);

// Produtos comecados pela letra C

var novalista12 = products.Where(x => x.Categoria.Name.StartsWith("C"))
.Select(x => new {Nome = x.Name, Preco = x.Price, NameCategoria = x.Categoria.Name});

var novalista3 = products.Where(x => x.Categoria.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name).ToList();

// Pula os dois primeiros elementos e mostra apenas 4
var novalista14 = novalista3.Skip(2).Take(4);

var novaLista5 = products.Where(x => x.Price > 500).Select(x => x.Price).DefaultIfEmpty(00).Average();