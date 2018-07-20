using System;
using Kzari.FinCtrl.Shared;
using Flunt.Notifications;

namespace Kzari.FinCtrl.Domain
{
    public class Registro : Entity
    {
        public string Descricao { get; set; }
        public string DescricaoBanco { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

        public virtual Categoria Categoria {get; set;}

        public bool ÉDebito => Valor < 0;
        public bool ÉCredito => Valor > 0;
    }
}