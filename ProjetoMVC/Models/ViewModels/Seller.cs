namespace ProjetoMVC.Models.ViewModels;

public class Seller
{
    public Seller()
    {

    }

    public Seller(int id, string name, string email, DateTime birthday, double baseSalary, Departaments departaments)
    {
        Id = id;
        Name = name;
        Email = email;
        Birthdate = birthday;
        BaseSalary = baseSalary;
        Departament = departaments;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateTime Birthdate { get; set; }
    public double BaseSalary { get; set; }
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