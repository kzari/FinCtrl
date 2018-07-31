using Kzari.Finctrl.Domain.Entities;
using Kzari.Finctrl.Domain.Repositories;

namespace Kzari.FinCtrl.Infra.Data.Repository
{
    public class RegistroRepository : Repository<Registro> , IRegistroRepository
    {
        public RegistroRepository(FinCtrlContext context) : base(context)
        {
        }
    }
}