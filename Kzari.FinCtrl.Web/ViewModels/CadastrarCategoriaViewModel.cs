using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Kzari.FinCtrl.Web.ViewModels
{
    public class CadastrarCategoriaViewModel
    {
        [Required]
        [Description("Nome")]
        public string Nome { get; set; }
    }
}
