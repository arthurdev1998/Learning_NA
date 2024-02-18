using System.ComponentModel.DataAnnotations.Schema;
using ProjetoMVC.Models.Enums;

namespace ProjetoMVC.Models.ViewModels;

public class SalesRecord
{
    public SalesRecord()
    {

    }

    public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
    {
        Id = id;
        Amount = amount;
        Date = date;
        Status = status;
        Seller = seller;
    }


    [Column("id")]
    public int Id { get; set; }

    [Column("amount")]
    public double Amount { get; set; }

    [Column("date")]
    public DateTime Date { get; set; }

    [Column("status")]
    public SaleStatus Status { get; set; }

    public Seller? Seller { get; set; }

    [ForeignKey("seller")]
    [Column("sellerid")]
    public int SellerId { get; set; }
}