using DescontoImpostoRenda.Dominio.Entities;

namespace DescontoImpostoRenda.Dominio.Interfaces.Respositorios
{
    public interface IFaixasSalariaisRepository : IRepositoryBase<FaixaSalarial>
    {
        FaixaSalarial ObterFaixaDoSalario(decimal salario);
    }
}
