using LanchesMac.Models;
using LanchesMac.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LanchesMac.Controllers;

public class LancheController : Controller
{
    private readonly ILancheRepository _lancheRepository;

    public LancheController(ILancheRepository lancheRepository) { _lancheRepository = lancheRepository; }

    public IActionResult List()
    {
        /*ViewData["Titulo"] = "Listando Lanches";
        ViewData["Data"] = DateTime.Now;
        ViewBag.Lanches = "Total de Lanches: ";
        ViewBag.TotalLanche = lanches.Count();*/
        
        var lanches = _lancheRepository.Lanches;
        return View(lanches);
    }
}
