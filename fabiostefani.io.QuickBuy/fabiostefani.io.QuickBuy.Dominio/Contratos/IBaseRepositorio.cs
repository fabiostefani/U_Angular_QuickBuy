using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntidade> : IDisposable where TEntidade: class
    {
        void Adicionar(TEntidade entidade);
        void Atualizar(TEntidade entidade);
        void Remover(TEntidade entidade);
        TEntidade ObterPorId(int id);
        IEnumerable<TEntidade> ObterTodos();
    }
}
