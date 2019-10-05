using fabiostefani.io.QuickBuy.Dominio.Contratos;
using fabiostefani.io.QuickBuy.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fabiostefani.io.QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntidade> : IBaseRepositorio<TEntidade> where TEntidade : class
    {
        protected readonly DbContext Db;
        protected readonly DbSet<TEntidade> DbSet;

        public BaseRepositorio(QuickBuyContexto contexto)
        {
            Db = contexto;
            DbSet = Db.Set<TEntidade>();
        }

        public void Adicionar(TEntidade entidade)
        {
            DbSet.Add(entidade);
            Db.SaveChanges();
        }

        public void Atualizar(TEntidade entidade)
        {
            DbSet.Update(entidade);
            Db.SaveChanges();
        }

        public TEntidade ObterPorId(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntidade> ObterTodos()
        {
            return DbSet.ToList();
        }

        public void Remover(TEntidade entidade)
        {
            DbSet.Remove(entidade);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
