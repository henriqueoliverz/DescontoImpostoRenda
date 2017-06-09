using DescontoImpostoRenda.Dominio.Entities;

namespace DescontoImpostoRenda.Dominio.Interfaces.Servicos
{
    public interface IFaixasSalariaisService : IServiceBase<FaixaSalarial>
    {
        FaixaSalarial ObterFaixaDoSalario(decimal salario);
    }
}
