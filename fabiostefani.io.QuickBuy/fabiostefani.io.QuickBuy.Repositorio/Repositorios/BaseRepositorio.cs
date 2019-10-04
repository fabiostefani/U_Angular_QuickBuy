using fabiostefani.io.QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntidade> : IBaseRepositorio<TEntidade> where TEntidade : class
    {
        public BaseRepositorio()
        {

        }

        public void Adicionar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public TEntidade ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntidade> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
