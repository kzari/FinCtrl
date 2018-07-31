using System.Collections.Generic;
using System.Linq;
using Kzari.Finctrl.Domain.Entities;
using Kzari.Finctrl.Domain.Services.Interfaces;
using Kzari.FinCtrl.Domain;
using Kzari.FinCtrl.Domain.Interfaces;

namespace Kzari.Finctrl.Domain.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public void Cadastrar(string nome)
        {
            if (!_repository.Existe(nome))
            {
                _repository.Add(new Categoria(nome));
                _repository.SaveChanges();
            }
        }

        public IEnumerable<Categoria> GetAll()
        {
            return _repository.GetAll().Where(a => a.Ativo).ToList();
        }
    }
}
