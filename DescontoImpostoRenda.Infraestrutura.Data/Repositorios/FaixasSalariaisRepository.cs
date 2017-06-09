using DescontoImpostoRenda.Dominio.Interfaces.Respositorios;
using DescontoImpostoRenda.Dominio.Entities;
using System.Linq;

namespace DescontoImpostoRenda.Infraestrutura.Data.Repositorios
{
    public class FaixasSalariaisRepository : RepositoryBase<FaixaSalarial>, IFaixasSalariaisRepository
    {
        public FaixaSalarial ObterFaixaDoSalario(decimal salario)
        {
            return DbContext.FaixasSalariais.SingleOrDefault(faixa => faixa.AceitaSalario(salario));
        }
    }
}
