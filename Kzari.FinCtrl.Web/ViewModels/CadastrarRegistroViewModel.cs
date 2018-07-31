using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kzari.FinCtrl.Web.ViewModels
{
    public class CadastrarRegistroViewModel
    {
        [Required, Display(Name = "Descrição"), StringLength(100)]
        public string Descricao { get; set; }

        [Display(Name = "Descrição do Banco"), StringLength(100)]
        public string DescricaoBanco { get; set; }

        [Required, Display(Name = "Data"), DataType(DataType.Date)]
        public DateTime Data { get; set; } = DateTime.Now;

        [Required, Display(Name = "Valor"), Range(0.01, 1000000000)]
        public decimal Valor { get; set; }

        [Display(Name = "Categoria")]
        public int? CategoriaId { get; set; }

        public IEnumerable<SelectListItem> Categorias { get; set; }
    }
}
