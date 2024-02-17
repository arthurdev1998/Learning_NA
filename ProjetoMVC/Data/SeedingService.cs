using ProjetoMVC.Models.ViewModels;

namespace ProjetoMVC.Data;

public class SeedingService
{
    private readonly ProjetoMVCContext _context;

    public SeedingService(ProjetoMVCContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        if (!_context.Departaments.Any())
        {
            var departamento1 = new Departaments()
            {
                Id = 1,
                Name = "Eletronics"
            };

            var departamento2 = new Departaments()
            {
                Id = 2,
                Name = "Books"
            };
            
            var departamento3 = new Departaments()
            {
                Id = 3,
                Name = "Fashions"
            };

            _context.Departaments.Add(departamento1);
            _context.Departaments.Add(departamento2);
            _context.SaveChanges();

        }
    }
}