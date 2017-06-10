using DescontoImpostoRenda.Dominio.Entities;
using DescontoImpostoRenda.Infraestrutura.Data.Context;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace DescontoImpostoRenda.Infraestrutura.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DescontoImpostoRendaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DescontoImpostoRendaContext context)
        {
            SeedFaixasSalariais(context);

            context.SaveChanges();
        }

        private void SeedFaixasSalariais(DescontoImpostoRendaContext context)
        {
            var faixasSalariais = new List<FaixaSalarial>
            {
                new FaixaSalarial
                {
                    SalarioMinimo = null,
                    SalarioMaximo = 1903.98M,
                    Aliquota = 0M,
                    Deduzir = 0M
                },
                new FaixaSalarial
                {
                    SalarioMinimo = 1903.99M,
                    SalarioMaximo = 2826.65M,
                    Aliquota = 0.075M,
                    Deduzir = 142.80M
                },
                new FaixaSalarial
                {
                    SalarioMinimo = 2826.66M,
                    SalarioMaximo = 3751.05M,
                    Aliquota = 0.15M,
                    Deduzir = 354.80M
                },
                new FaixaSalarial
                {
                    SalarioMinimo = 3751.06M,
                    SalarioMaximo = 4664.68M,
                    Aliquota = 0.225M,
                    Deduzir = 636.13M
                },
                new FaixaSalarial
                {
                    SalarioMinimo = 4664.68M,
                    SalarioMaximo = null,
                    Aliquota = 0.275M,
                    Deduzir = 869.36M
                }
            };

            context.FaixasSalariais.AddRange(faixasSalariais);
        }

    }
}
