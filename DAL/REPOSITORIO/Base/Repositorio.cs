using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contexto;
using System.Data.Entity;

namespace DAL.Repositorio.Base
{
    public abstract class Repositorio<TEntity> : IDisposable,
       IRepositorio<TEntity> where TEntity : class
    {
        BancoContexto banco = new BancoContexto();

        public IQueryable<TEntity> GetAll()
        {
            return banco.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return banco.Set<TEntity>().Find(key);
        }

        public void Atualizar(TEntity obj)
        {
            banco.Entry(obj).State = EntityState.Modified;
        }

        public void SalvarTodos()
        {
            banco.SaveChanges();
        }

        public void Adicionar(TEntity obj)
        {
            banco.Set<TEntity>().Add(obj);
        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            banco.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => banco.Set<TEntity>().Remove(del));
        }

        public void Dispose()
        {
            banco.Dispose();
        }
    }
}
