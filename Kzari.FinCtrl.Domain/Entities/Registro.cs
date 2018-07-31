using System;
using System.ComponentModel.DataAnnotations.Schema;
using Kzari.FinCtrl.Shared;

namespace Kzari.Finctrl.Domain.Entities
{
    public class Registro : Entity
    {
        public Registro(string descricao, string descricaoBanco, DateTime data, decimal valor, int? categoriaId = null)
        {
            Descricao = descricao;
            DescricaoBanco = descricaoBanco;
            Data = data;
            Valor = valor;
            CategoriaId = categoriaId;
        }

        //For EF
        private Registro()
        {
        }

        public string Descricao { get; set; }
        public string DescricaoBanco { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

        [ForeignKey(nameof(CategoriaId))]
        public int? CategoriaId { get; set; }
        public Categoria Categoria {get; set;}

        public bool ÉDebito => Valor < 0;
        public bool ÉCredito => Valor > 0;
    }
}