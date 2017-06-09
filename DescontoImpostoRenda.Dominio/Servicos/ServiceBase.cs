using DescontoImpostoRenda.Dominio.Interfaces.Respositorios;
using DescontoImpostoRenda.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescontoImpostoRenda.Dominio.Servicos
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        private IFaixasSalariaisService faixasSalariaisRepository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Adicionar(TEntity objeto)
        {
            _repository.Adicionar(objeto);
        }

        public void Deletar(TEntity objeto)
        {
            _repository.Deletar(objeto);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public void Editar(TEntity objeto)
        {
            _repository.Editar(objeto);
        }

        public TEntity ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}
