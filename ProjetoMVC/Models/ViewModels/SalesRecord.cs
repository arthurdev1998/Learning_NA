using ProjetoMVC.Models.Enums;

namespace ProjetoMVC.Models.ViewModels;

public class SalesRecord
{
    public SalesRecord()
    {

    }

    public SalesRecord(int id, double amount, DateTime date, SaleStatus status, Seller seller)
    {
        Id = id;
        Amount = amount;
        Date = date;
        Status = status;
        Seller = seller;
    }

    public int Id { get; set; }
    public double Amount { get; set; }
    public DateTime Date { get; set; }
    public SaleStatus Status { get; set; }
    public Seller? Seller { get; set; }
}