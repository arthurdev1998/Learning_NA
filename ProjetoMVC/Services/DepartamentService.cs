using ProjetoMVC.Data;
using ProjetoMVC.Models.ViewModels;

namespace ProjetoMVC.Services;

public class DepartamentService
{
    private readonly ProjetoMVCContext _context;
    
    public DepartamentService(ProjetoMVCContext context)
    {
        _context = context;
    }

    public List<Departaments> GetAll()
    {
        return [.. _context.Departaments.OrderBy(x => x.Name)];
    }
}