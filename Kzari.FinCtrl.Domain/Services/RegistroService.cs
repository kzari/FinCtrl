using Kzari.Finctrl.Domain.Entities;
using Kzari.Finctrl.Domain.Repositories;
using Kzari.Finctrl.Domain.Services.Interfaces;

namespace Kzari.Finctrl.Domain.Services
{
    public class RegistroService : IRegistroService
    {
        private readonly IRegistroRepository _registroRepository;

        public RegistroService(IRegistroRepository registroRepository)
        {
            _registroRepository = registroRepository;
        }

        public void Cadastrar(Registro registro)
        {
            _registroRepository.Add(registro);
            _registroRepository.SaveChanges();
        }
    }
}
