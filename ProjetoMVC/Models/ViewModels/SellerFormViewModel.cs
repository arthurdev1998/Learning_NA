namespace ProjetoMVC.Models.ViewModels;

public class SellerFormViewModel
{
    public required Seller Seller { get; set; }
    public IEnumerable<Departaments>? Departaments { get; set; }
}