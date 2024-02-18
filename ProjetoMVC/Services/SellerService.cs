using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjetoMVC.Data;
using ProjetoMVC.Models.ViewModels;

namespace ProjetoMVC.Services;

public class SellerService
{
    private readonly ProjetoMVCContext _context;
    public SellerService(ProjetoMVCContext context)
    {
        _context = context;
    }
    
    public List<Seller> GetAllSellers()
    {
        return _context.Seller.ToList();
    }
 
    public void Create(Seller seller)
    {   
        var ids = _context.Seller.Select(x => x.Id).ToList();
        var id = Extension.ExtensionMethods.ValidateId(ids);
        
        seller.Departament = _context.Departaments.First();
        seller.Birthdate = new DateTime().ToUniversalTime();
        _context.Seller.Add(seller);
        _context.SaveChanges();
    }
}