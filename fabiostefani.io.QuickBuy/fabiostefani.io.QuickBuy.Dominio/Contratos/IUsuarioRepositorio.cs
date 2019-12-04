using fabiostefani.io.QuickBuy.Dominio.Entidades;

namespace fabiostefani.io.QuickBuy.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario ExisteUsuarioPorUsuarioSenha(Usuario usuario);
        bool UsuarioJaCadastrado(string email);
    }
}
