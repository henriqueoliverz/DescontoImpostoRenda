using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescontoImpostoRenda.Aplicacao.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity objeto);
        void Editar(TEntity objeto);
        void Deletar(TEntity objeto);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Dispose();
    }
}
