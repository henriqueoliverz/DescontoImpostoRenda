using DescontoImpostoRenda.Dominio.Entities;
using DescontoImpostoRenda.Dominio.Interfaces.Respositorios;
using DescontoImpostoRenda.Dominio.Interfaces.Servicos;
using System;

namespace DescontoImpostoRenda.Dominio.Servicos
{
    public class FaixasSalariaisService : ServiceBase<FaixaSalarial>, IFaixasSalariaisRepository
    {
        private readonly IFaixasSalariaisRepository _faixasSalariaisRepository;
        public FaixasSalariaisService(IFaixasSalariaisRepository faixasSalariaisRepository)
            : base(faixasSalariaisRepository)
        {
            _faixasSalariaisRepository = faixasSalariaisRepository;
        }

        public FaixaSalarial ObterFaixaDoSalario(decimal salario)
        {
            return _faixasSalariaisRepository.ObterFaixaDoSalario(salario);
        }
    }
}
