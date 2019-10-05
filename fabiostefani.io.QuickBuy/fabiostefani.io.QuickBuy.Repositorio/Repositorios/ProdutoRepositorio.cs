using fabiostefani.io.QuickBuy.Dominio.Contratos;
using fabiostefani.io.QuickBuy.Dominio.Entidades;
using fabiostefani.io.QuickBuy.Repositorio.Contexto;

namespace fabiostefani.io.QuickBuy.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickBuyContexto quickBuyContexto)
            : base(quickBuyContexto)
        {

        }
    }
}
