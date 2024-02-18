using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models.ViewModels;
using ProjetoMVC.Services;

namespace ProjetoMVC.Controllers;

[Route("[controller]")]
public class SellersController : Controller
{
    private readonly SellerService _sellerService;
    private readonly DepartamentService _departament;

    public SellersController(SellerService sellerService, DepartamentService departament)
    {
        _sellerService = sellerService;
        _departament = departament;
    }

    [HttpGet("/index")]
    public IActionResult Index()
    {
        return View(_sellerService.GetAllSellers());
    }

    public IActionResult Create()
    {
        var departaments = _departament.GetAll();
        var model = new SellerFormViewModel { Departaments = departaments, Seller = new Seller { Name = string.Empty } };
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Seller seller)
    {
        _sellerService.Create(seller);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet("/{id}")]
    public IActionResult Delete(int? id)
    {
        if (id != null)
        {
            var seller = _sellerService.GetById(id.Value);
            return View(seller);
        }

        return NotFound();
    }

    [HttpPost("/{id}")]
    public IActionResult Delete(int id)
    {
        _sellerService.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}