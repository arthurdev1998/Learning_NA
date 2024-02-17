using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models.ViewModels;

public class Departaments
{
    public Departaments()
    {

    }

    public Departaments(int id, string name)
    {
        Id = id;
        Name = name;
    }

    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Seller> Sellers { get; set; } = [];

    public void AddSeller(Seller sr)
    {
        Sellers.Add(sr);
    }

    public double TotalSales(DateTime init, DateTime final)
    {
        // double vendas = 0.0;
        // var vendedores = Sellers.Where(x => x.Departament.Id == Id).ToList();
        // vendedores.ForEach(x => vendas += x.Sales.Where(e => e.Date > init && e.Date < final).Sum(p => p.Amount));
        // return vendas;

        return Sellers.Sum(x => x.TotalSales(init, final));
    }
}