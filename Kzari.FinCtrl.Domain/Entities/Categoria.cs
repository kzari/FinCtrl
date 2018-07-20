using Kzari.FinCtrl.Shared;

namespace Kzari.FinCtrl.Domain
{
    public class Categoria : Entity
    {
        public Categoria(string nome)
        {
            Nome = nome;

            //if(string.IsNullOrEmpty(Nome))
            //    AddNotification(nameof(Nome), "Nome inválido.");

            //AddNotifications(new Contract()
            //    .Requires()
            //    .IsNotNullOrEmpty(Nome, nameof(Nome), "Nome inválido")
            //    .HasMaxLen(Nome, 100, nameof(Nome), "O Nome deve ter até 100 caracteres")
            //);
        }

        public string Nome { get; private set; }
    }
}