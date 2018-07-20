namespace Kzari.Finctrl.Domain.Services.Interfaces
{
    public interface ICategoriaService
    {
        /// <summary>
        /// Cadastrar uma nova categoria
        /// </summary>
        /// <param name="nome"></param>
        void Cadastrar(string nome);
    }
}
