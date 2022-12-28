using LanchesMac.Models;

namespace LanchesMac.Repository.Intefaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
