using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models.ViewModels;
using ProjetoMVC.Services;

namespace ProjetoMVC.Controllers;

[Route("[controller]")]
public class SellersController : Controller
{
    private readonly SellerService _sellerService;

    public SellersController(SellerService sellerService)
    {
        _sellerService = sellerService;
    }

    [HttpGet("/index")]
    public IActionResult Index()
    {
        return View(_sellerService.GetAllSellers());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Seller seller)
    {
        _sellerService.Create(seller);
        return RedirectToAction(nameof(Index));
    }
}