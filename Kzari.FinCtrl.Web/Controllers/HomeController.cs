using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Kzari.FinCtrl.Web.Models;
using Kzari.FinCtrl.Web.ViewModels;
using Kzari.Finctrl.Domain.Services.Interfaces;

namespace Kzari.FinCtrl.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public HomeController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult CadastrarCategoria()
        {
            return View(new CategoriaViewModel());
        }

        [HttpPost]
        public IActionResult CadastrarCategoria(CategoriaViewModel vm)
        {
            if(!ModelState.IsValid)
                return View(vm);

            _categoriaService.Cadastrar(vm.Nome);

            return View(vm);
        }
    }
}
