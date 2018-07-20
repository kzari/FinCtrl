using System;
using Flunt.Notifications;

namespace Kzari.FinCtrl.Shared
{
    public abstract class Entity
    {
        protected Entity()
        {
            Ativo = true;
            DataInclusao = DateTime.Now;
        }

        protected void Editar()
        {
            DataUltimaAlteracao = DateTime.Now;
        }

        public int Id { get; private set; }
        public DateTime DataInclusao { get; private set; }
        public DateTime? DataUltimaAlteracao { get; private set; }
        public bool Ativo { get; private set; }
    }
}