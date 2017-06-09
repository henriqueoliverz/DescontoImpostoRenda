using DescontoImpostoRenda.Aplicacao.Interfaces;
using DescontoImpostoRenda.Dominio.Entities;
using DescontoImpostoRenda.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescontoImpostoRenda.Aplicacao.ApplicationServices
{
    class FaixasSalariaisAppService : AppServiceBase<FaixaSalarial>, IFaixasSalariaisAppService
    {
        private readonly IFaixasSalariaisService _faixasSalariaisService;
        public FaixasSalariaisAppService(IFaixasSalariaisService faixasSalariais)
            :base(faixasSalariais)
        {
            _faixasSalariaisService = faixasSalariais;
        }

        public FaixaSalarial ObterFaixaDoSalario(decimal salario)
        {
            return _faixasSalariaisService.ObterFaixaDoSalario(salario);
        }
    }
}
