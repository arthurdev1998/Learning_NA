using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models.ViewModels;

namespace ProjetoMVC.Data;

public class ProjetoMVCContext : DbContext
{
    public ProjetoMVCContext(DbContextOptions<ProjetoMVCContext> options)
        : base(options)
    {
    }

    public DbSet<Departaments> Departaments { get; set; } = default!;
    public DbSet<Seller> Seller { get; set; } = default!;
    public DbSet<SalesRecord> SalesRecords { get; set; } = default!;
}