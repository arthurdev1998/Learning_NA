using ProjetoMVC.Models.Enums;
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

        if (_context.Departaments.Any() &&
            _context.Seller.Any() &&
            _context.SalesRecords.Any())
        {
            return; // DB has been seeded
        }

        Departaments d1 = new Departaments(1, "Computers");
        Departaments d2 = new Departaments(2, "Electronics");
        Departaments d3 = new Departaments(3, "Fashion");
        Departaments d4 = new Departaments(4, "Books");

        Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21).ToUniversalTime(), 1000.0, d1);
        Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31).ToUniversalTime(), 3500.0, d2);
        Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15).ToUniversalTime(), 2200.0, d1);
        Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30).ToUniversalTime(), 3000.0, d4);
        Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9).ToUniversalTime(), 4000.0, d3);
        Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4).ToUniversalTime(), 3000.0, d2);

        SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25).ToUniversalTime(), 11000.0, SaleStatus.Billed, s1);
        SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4).ToUniversalTime(), 7000.0, SaleStatus.Billed, s5);
        SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13).ToUniversalTime(), 4000.0, SaleStatus.Canceled, s4);
        SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 1).ToUniversalTime(), 8000.0, SaleStatus.Billed, s1);
        SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 21).ToUniversalTime(), 3000.0, SaleStatus.Billed, s3);
        SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 15).ToUniversalTime(), 2000.0, SaleStatus.Billed, s1);
        SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 28).ToUniversalTime(), 13000.0, SaleStatus.Billed, s2);
        SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 11).ToUniversalTime(), 4000.0, SaleStatus.Billed, s4);
        SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 14).ToUniversalTime(), 11000.0, SaleStatus.Pending, s6);
        SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 7).ToUniversalTime(), 9000.0, SaleStatus.Billed, s6);
        SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 13).ToUniversalTime(), 6000.0, SaleStatus.Billed, s2);
        SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 25).ToUniversalTime(), 7000.0, SaleStatus.Pending, s3);
        SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 29).ToUniversalTime(), 10000.0, SaleStatus.Billed, s4);
        SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 4).ToUniversalTime(), 3000.0, SaleStatus.Billed, s5);
        SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 12).ToUniversalTime(), 4000.0, SaleStatus.Billed, s1);
        SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 10, 5).ToUniversalTime(), 2000.0, SaleStatus.Billed, s4);
        SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 10, 1).ToUniversalTime(), 12000.0, SaleStatus.Billed, s1);
        SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 10, 24).ToUniversalTime(), 6000.0, SaleStatus.Billed, s3);
        SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 10, 22).ToUniversalTime(), 8000.0, SaleStatus.Billed, s5);
        SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 10, 15).ToUniversalTime(), 8000.0, SaleStatus.Billed, s6);
        SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 10, 17).ToUniversalTime(), 9000.0, SaleStatus.Billed, s2);
        SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 10, 24).ToUniversalTime(), 4000.0, SaleStatus.Billed, s4);
        SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 10, 19).ToUniversalTime(), 11000.0, SaleStatus.Canceled, s2);
        SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 10, 12).ToUniversalTime(), 8000.0, SaleStatus.Billed, s5);
        SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 10, 31).ToUniversalTime(), 7000.0, SaleStatus.Billed, s3);
        SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 10, 6).ToUniversalTime(), 5000.0, SaleStatus.Billed, s4);
        SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 10, 13).ToUniversalTime(), 9000.0, SaleStatus.Pending, s1);
        SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 10, 7).ToUniversalTime(), 4000.0, SaleStatus.Billed, s3);
        SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 10, 23).ToUniversalTime(), 12000.0, SaleStatus.Billed, s5);
        SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 10, 12).ToUniversalTime(), 5000.0, SaleStatus.Billed, s2);

        _context.Departaments.AddRange(d1, d2, d3, d4);

        _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

        _context.AddRange(
            r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
            r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
            r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
        );

        _context.SaveChanges();

    }
}