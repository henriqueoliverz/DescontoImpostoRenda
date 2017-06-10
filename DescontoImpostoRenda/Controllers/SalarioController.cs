using DescontoImpostoRenda.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DescontoImpostoRenda.Controllers
{
    public class SalarioController : Controller
    {
        private readonly IFaixasSalariaisAppService _faixasSalariaisApp;

        public SalarioController(IFaixasSalariaisAppService faixasSalariaisApp)
        {
            _faixasSalariaisApp = faixasSalariaisApp;
        }

        [HttpPost]
        public ActionResult ImpostoRenda(decimal salario)
        {
            var faixaSalarial = _faixasSalariaisApp.ObterFaixaDoSalario(salario);

            var imposto = faixaSalarial.CalcularImposto(salario);
            
            return Json(imposto);
        }
    }
}