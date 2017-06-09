using DescontoImpostoRenda.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescontoImpostoRenda.Aplicacao.Interfaces
{
    public interface IFaixasSalariaisAppService : IAppServiceBase<FaixaSalarial>
    {
        FaixaSalarial ObterFaixaDoSalario(decimal salario);
    }
}
