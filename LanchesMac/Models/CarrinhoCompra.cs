using LanchesMac.Context;

namespace LanchesMac.Models;

public class CarrinhoCompra
{
    private readonly AppDbContext _context;
    public CarrinhoCompra(AppDbContext context) { _context = context; } //ele chama a injeção de dependencia
    public string CarrinhoCompraId { get; set; }
    public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
    public static CarrinhoCompra GetCarrinho(IServiceProvider service)
    {
        //DEFINE UMA SESSÃO
        ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
        //OBTEM UM SERVIÇO DO TIPO DO NOSSO CONTEXTO
        var context = service.GetService<AppDbContext>();
        //OBTEM OU GERA O ID DO CARRINHO
        string carrinhoId = session.GetString("CarrinhoId")??Guid.NewGuid().ToString();
        //ATRIBUI O ID DO CARRINHO 
        session.SetString("CarrinhoId", carrinhoId);
        //retorna o carrinho com o contexto e o ID atribuido ou obtido
        return new CarrinhoCompra(context)
        {
            CarrinhoCompraId = carrinhoId
        };
    }
}
