using fabiostefani.io.QuickBuy.Dominio.Contratos;
using fabiostefani.io.QuickBuy.Dominio.Entidades;
using fabiostefani.io.QuickBuy.Repositorio.Contexto;
using System.Linq;

namespace fabiostefani.io.QuickBuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickBuyContexto quickBuyContexto)
            : base(quickBuyContexto)
        {

        }

        public bool ExisteUsuarioPorUsuarioSenha(Usuario usuario)
        {
            return ObterTodos().Any(x => x.Email == usuario.Email && x.Senha == usuario.Senha);
        }
    }
}
