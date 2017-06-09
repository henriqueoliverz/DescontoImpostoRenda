using DescontoImpostoRenda.Aplicacao.Interfaces;
using DescontoImpostoRenda.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescontoImpostoRenda.Aplicacao.ApplicationServices
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Adicionar(TEntity objeto)
        {
            _serviceBase.Adicionar(objeto);
        }

        public void Deletar(TEntity objeto)
        {
            _serviceBase.Deletar(objeto);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public void Editar(TEntity objeto)
        {
            _serviceBase.Editar(objeto);
        }

        public TEntity ObterPorId(int id)
        {
            return _serviceBase.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _serviceBase.ObterTodos();
        }
    }
}
