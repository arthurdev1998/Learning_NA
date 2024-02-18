using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Data;
using ProjetoMVC.Extension;
using ProjetoMVC.Models.ViewModels;

namespace ProjetoMVC.Services;

public class SellerService
{
    private readonly ProjetoMVCContext _context;

    public SellerService(ProjetoMVCContext context)
    {
        _context = context;
    }

    public IEnumerable<Seller> GetAllSellers()
    {
        return [.. _context.Seller.OrderBy(x => x.Id).AsNoTracking()];
    }

    public void Create(Seller seller)
    {
        var ids = _context.Seller.OrderBy(x => x.Id).Select(x => x.Id).ToList();
        seller.Id = ids.ValidateId();

        seller.Departament = _context.Departaments.First();
        seller.Birthdate = new DateTime().ToUniversalTime();

        _context.Seller.Add(seller);
        _context.SaveChanges();
    }

    public Seller? GetById(int id)
    {
        return _context.Seller.Include(x => x.Sales).FirstOrDefault(x => x.Id == id);
    }

    public void Delete(int id)
    {
        var seller = GetById(id);

        if (seller != null)
        {
            _context.Seller.Remove(seller);
        }

        _context.SaveChanges();
    }
}