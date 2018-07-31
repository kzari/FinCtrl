using System.Linq;
using Kzari.Finctrl.Domain.Entities;
using Kzari.Finctrl.Domain.Services.Interfaces;
using Kzari.FinCtrl.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kzari.FinCtrl.Web.Controllers
{
    public class RegistroController : Controller
    {
        private readonly IRegistroService _registroService;
        private readonly ICategoriaService _categoriaService;

        public RegistroController(IRegistroService registroService, ICategoriaService categoriaService)
        {
            _registroService = registroService;
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var viewModel = new CadastrarRegistroViewModel();

            var categorias = _categoriaService.GetAll();
            viewModel.Categorias = categorias.Select(a => new SelectListItem(a.Nome, a.Id.ToString()));

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarRegistroViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Categorias = _categoriaService.GetAll().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
                return View(vm);
            }

            var registro = new Registro(vm.Descricao, vm.DescricaoBanco, vm.Data, vm.Valor, vm.CategoriaId);

            _registroService.Cadastrar(registro);

            return RedirectToAction("Index", "Home");
        }
    }
}
