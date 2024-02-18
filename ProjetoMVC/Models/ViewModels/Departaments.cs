using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMVC.Models.ViewModels;

[Table("Departament")]
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
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
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