using DescontoImpostoRenda.Dominio.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DescontoImpostoRenda.Infraestrutura.Data.Mapping
{
    public class FaixaSalarialMap : EntityTypeConfiguration<FaixaSalarial>
    {
        public FaixaSalarialMap()
        {
            ToTable("FaixasSalariais");

            HasKey(props => props.FaixaSalarialId);
        }
    }
}
