using LanchesMac.Models;

namespace LanchesMac.Repository.Interfaces;

public interface ILancheRepository
{
    IEnumerable<Lanche> Lanches { get; }
    IEnumerable<Lanche> LanchesPreferidos { get; }
    Lanche GetLancheById(int id);//Implementando Função porem na interface nao funciona, porem na classe concreta
}
