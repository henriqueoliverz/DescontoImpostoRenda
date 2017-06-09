using System.Collections.Generic;

namespace DescontoImpostoRenda.Dominio.Interfaces.Servicos
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity objeto);
        void Editar(TEntity objeto);
        void Deletar(TEntity objeto);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Dispose();
    }
}
