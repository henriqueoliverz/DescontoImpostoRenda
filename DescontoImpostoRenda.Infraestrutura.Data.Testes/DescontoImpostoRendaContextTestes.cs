using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DescontoImpostoRenda.Infraestrutura.Data.Context;

namespace DescontoImpostoRenda.Infraestrutura.Data.Testes
{
    [TestClass]
    public class DescontoImpostoRendaContextTestes
    {
        [TestMethod]
        public void ContextoInstanciadoPorCreate()
        {
            DescontoImpostoRendaContext contexto = DescontoImpostoRendaContext.Create();

            Assert.IsNotNull(contexto);
        }
    }
}
