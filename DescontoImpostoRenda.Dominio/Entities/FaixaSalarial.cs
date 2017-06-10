using System;

namespace DescontoImpostoRenda.Dominio.Entities
{
    public class FaixaSalarial
    {
        public int FaixaSalarialId { get; set; }
        
        public decimal Aliquota { get; set; }
        public decimal? SalarioMinimo { get; set; }
        public decimal? SalarioMaximo { get; set; }
        public decimal Deduzir { get; set; }

        public virtual bool AceitaSalario(decimal salario)
        {
            return (this.SalarioMinimo != null || this.SalarioMaximo != null) &&  
                (this.SalarioMinimo == null || salario >= this.SalarioMinimo) 
                && (this.SalarioMaximo == null || salario <= this.SalarioMaximo);
        }

        public virtual decimal CalcularImposto(decimal salario)
        {
            if (!AceitaSalario(salario))
                throw new Exception("Salário não pertence a faixa salarial especificada.");

            return Math.Round(salario * Aliquota - Deduzir, 2);
        }

    }
}
