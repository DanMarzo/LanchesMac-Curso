using LanchesMac.Models;

namespace LanchesMac.Repository.Interfaces;

public interface ILancheRepository
{
    public IEnumerable<Lanche> Lanches { get; }
    public IEnumerable<Lanche> LanchesPreferidos { get; }
    public Lanche GetLancheById(int id);//Implementando Função porem na interface nao funciona, porem na classe concreta
}
