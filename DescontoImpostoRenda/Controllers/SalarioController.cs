using DescontoImpostoRenda.Aplicacao.Interfaces;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;

namespace DescontoImpostoRenda.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SalarioController : ApiController
    {
        private readonly IFaixasSalariaisAppService _faixasSalariaisApp;

        public SalarioController(IFaixasSalariaisAppService faixasSalariaisApp)
        {
            _faixasSalariaisApp = faixasSalariaisApp;
        }
        [HttpGet]
        public HttpResponseMessage ImpostoRenda(decimal salario)
        {
            var faixaSalarial = _faixasSalariaisApp.ObterFaixaDoSalario(salario);

            var imposto = faixaSalarial.CalcularImposto(salario);

            JavaScriptSerializer serialiser = new JavaScriptSerializer();
            HttpContext.Current.Response.ContentType = "application/json";
            HttpContext.Current.Response.Write(serialiser.Serialize(imposto));
            return new HttpResponseMessage();
        }
    }
}