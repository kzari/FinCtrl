using System.Linq;
using Kzari.Finctrl.Domain.Entities;
using Kzari.FinCtrl.Domain;
using Kzari.FinCtrl.Domain.Interfaces;

namespace Kzari.FinCtrl.Infra.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(FinCtrlContext context) : base(context)
        {
        }

        public bool Existe(string nome)
        {
            return Db.Categorias.Any(a => a.Nome == nome);
        }
    }
}