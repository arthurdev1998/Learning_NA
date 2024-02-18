using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMVC.Models.ViewModels;

[Table("seller")]
public class Seller
{
    public Seller()
    {

    }

    public Seller(int id, string name, string email, DateTime? birthday, double baseSalary, Departaments departaments)
    {
        Id = id;
        Name = name;
        Email = email;
        Birthdate = birthday;
        BaseSalary = baseSalary;
        Departament = departaments;
    }


    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("birthdate")]
    public DateTime? Birthdate { get; set; }

    [Column("base_salary")]
    public double BaseSalary { get; set; }

    [ForeignKey("departament")]
    public int DepartamentId { get; set; }

    public Departaments? Departament { get; set; }

    public ICollection<SalesRecord> Sales { get; set; } = [];


    public void AddSales(SalesRecord sale)
    {
        Sales.Add(sale);
    }

    public void Remove(SalesRecord sales)
    {
        Sales.Remove(sales);
    }

    public double TotalSales(DateTime initial, DateTime final)
    {
        return Sales.Where(x => x.Date > initial && x.Date < final).Sum(x => x.Amount);
    }
}