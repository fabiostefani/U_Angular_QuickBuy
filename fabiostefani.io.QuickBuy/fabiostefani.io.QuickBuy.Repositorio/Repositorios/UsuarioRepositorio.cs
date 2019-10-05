using fabiostefani.io.QuickBuy.Dominio.Contratos;
using fabiostefani.io.QuickBuy.Dominio.Entidades;
using fabiostefani.io.QuickBuy.Repositorio.Contexto;

namespace fabiostefani.io.QuickBuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickBuyContexto quickBuyContexto)
            : base(quickBuyContexto)
        {

        }
    }
}
