using fabiostefani.io.QuickBuy.Dominio.Entidades;

namespace fabiostefani.io.QuickBuy.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        bool ExisteUsuarioPorUsuarioSenha(Usuario usuario);
    }
}
