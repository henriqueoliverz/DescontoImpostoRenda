using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DescontoImpostoRenda.Dominio.Entities;

namespace DescontoImpostoRenda.Dominio.Testes
{
    [TestClass]
    public class FaixaSalarialTestes
    {
        #region Compatibilidade com a Faixa

        [TestMethod]
        public void SalarioMenorFaixaSalarial()
        {
            var faixaSalarial = new FaixaSalarial
            {
                SalarioMinimo = 936M,
                SalarioMaximo = 1903.98M,
                Aliquota = 0M,
                Deduzir = 0M
            };

            var aceite = faixaSalarial.AceitaSalario(800M);

            Assert.AreEqual(aceite, false);
        }

        [TestMethod]
        public void SalarioMaiorFaixaSalarial()
        {
            var faixaSalarial = new FaixaSalarial
            {
                SalarioMinimo = 936M,
                SalarioMaximo = 1903.98M,
                Aliquota = 0M,
                Deduzir = 0M
            };

            var aceite = faixaSalarial.AceitaSalario(2000M);

            Assert.AreEqual(aceite, false);
        }

        [TestMethod]
        public void SalarioAtendendoFaixaSalarial()
        {
            var faixaSalarial = new FaixaSalarial
            {
                SalarioMinimo = 936M,
                SalarioMaximo = 1903.98M,
                Aliquota = 0M,
                Deduzir = 0M
            };

            var aceite = faixaSalarial.AceitaSalario(1600M);

            Assert.AreEqual(aceite, true);
        }
        #endregion

        #region Calculo do Imposto

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SalarioDiferenteDaFaixaSalarial()
        {
            var faixaSalarial = new FaixaSalarial
            {
                SalarioMinimo = 936M,
                SalarioMaximo = 1903.98M,
                Aliquota = 0M,
                Deduzir = 0M
            };

            var imposto = faixaSalarial.CalcularImposto(800M);
            Assert.AreEqual(imposto, 800M);
        }

        [TestMethod]
        public void SalarioCorretamenteNaFaixaSalarialSemAliquotaEDeduzir()
        {
            var faixaSalarial = new FaixaSalarial
            {
                SalarioMinimo = 936M,
                SalarioMaximo = 1903.98M,
                Aliquota = 0M,
                Deduzir = 0M
            };

            var imposto = faixaSalarial.CalcularImposto(1000M);
            Assert.AreEqual(imposto, 0);
        }

        [TestMethod]
        public void SalarioCorretamenteNaFaixaSalarialSemDeduzir()
        {
            var faixaSalarial = new FaixaSalarial
            {
                SalarioMinimo = 936M,
                SalarioMaximo = 1903.98M,
                Aliquota = 0.225M,
                Deduzir = 0M
            };

            var imposto = faixaSalarial.CalcularImposto(1000M);
            Assert.AreEqual(imposto, 225M);
        }

        [TestMethod]
        public void SalarioCorretamenteNaFaixaSalarialCompleto()
        {
            var faixaSalarial = new FaixaSalarial
            {
                SalarioMinimo = 3751.06M,
                SalarioMaximo = 4664.68M,
                Aliquota = 0.225M,
                Deduzir = 636.13M
            };

            var imposto = faixaSalarial.CalcularImposto(4000M);
            Assert.AreEqual(imposto, 263.87M);
        }

        [TestMethod]
        public void SalarioCorretamenteNaFaixaSalarialSemMinimo()
        {
            var faixaSalarial = new FaixaSalarial
            {
                SalarioMinimo = null,
                SalarioMaximo = 1000M,
                Aliquota = 0.15M,
                Deduzir = 0M
            };

            var imposto = faixaSalarial.CalcularImposto(1000M);
            Assert.AreEqual(imposto, 150M);
        }

        [TestMethod]
        public void SalarioCorretamenteNaFaixaSalarialSemMaximo()
        {
            var faixaSalarial = new FaixaSalarial
            {
                SalarioMinimo = 4664.68M,
                SalarioMaximo = null,
                Aliquota = 0.275M,
                Deduzir = 869.36M
            };

            var imposto = faixaSalarial.CalcularImposto(5000M);
            Assert.AreEqual(imposto, 505.64M);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FaixaSalarialComMinimoEMaximoNulos()
        {
            var faixaSalarial = new FaixaSalarial
            {
                SalarioMinimo = null,
                SalarioMaximo = null,
                Aliquota = 0.225M,
                Deduzir = 300M
            };

            var imposto = faixaSalarial.CalcularImposto(2000M);
            Assert.AreEqual(imposto, 150M);
        }

        #endregion
    }
}
