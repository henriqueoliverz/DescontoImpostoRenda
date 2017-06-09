using DescontoImpostoRenda.Dominio.Interfaces.Respositorios;
using DescontoImpostoRenda.Infraestrutura.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescontoImpostoRenda.Infraestrutura.Data.Repositorios
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DescontoImpostoRendaContext DbContext = new DescontoImpostoRendaContext();

        public void Adicionar(TEntity objeto)
        {
            DbContext.Set<TEntity>().Add(objeto);
            DbContext.SaveChanges();
        }

        public void Deletar(TEntity objeto)
        {
            DbContext.Set<TEntity>().Remove(objeto);
            DbContext.SaveChanges();
        }

        public void Editar(TEntity objeto)
        {
            DbContext.Entry(objeto).State = EntityState.Modified;
            DbContext.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return DbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return DbContext.Set<TEntity>().ToList();
        }
        
        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}
