using LanchesMac.Models;
using LanchesMac.Repository.Interfaces;
using LanchesMac.ViewModel;
using Microsoft.AspNetCore.Mvc;

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

        //var lanches = _lancheRepository.Lanches;
        var lancheListViewModel = new LancheListViewModel();
        lancheListViewModel.Lanches = _lancheRepository.Lanches;
        lancheListViewModel.CategoriaAtual = "Categoria Frita";

        return View(lancheListViewModel);
    }
}
