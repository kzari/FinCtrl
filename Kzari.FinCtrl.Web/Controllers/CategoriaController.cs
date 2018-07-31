using Kzari.Finctrl.Domain.Services.Interfaces;
using Kzari.FinCtrl.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Kzari.FinCtrl.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new CadastrarCategoriaViewModel());
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarCategoriaViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            _categoriaService.Cadastrar(vm.Nome);

            return View(vm);
        }
    }
}
