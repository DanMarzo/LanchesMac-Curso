using LanchesMac.Context;
using LanchesMac.Models;

namespace LanchesMac.Repository.Interfaces;

public interface ICategoriaRepository 
{
    public IEnumerable<Categoria> Categorias { get; }//retorna uma coleção de categorias, e por so ter o metodo Get; somente leitura
}
