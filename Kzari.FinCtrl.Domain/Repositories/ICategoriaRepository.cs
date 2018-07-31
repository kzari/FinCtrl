using Kzari.Finctrl.Domain.Entities;

namespace Kzari.FinCtrl.Domain.Interfaces
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        /// <summary>
        /// Verifica se existe a categoria com este nome
        /// </summary>
        /// <param name="nome">Nome da categoria</param>
        /// <returns></returns>
        bool Existe(string nome);
    }
}