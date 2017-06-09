using DescontoImpostoRenda.Dominio.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace DescontoImpostoRenda.Infraestrutura.Data.Context
{
    public class DescontoImpostoRendaContext : DbContext, IDisposable
    {
        public DbSet<FaixaSalarial> FaixasSalariais { get; set; }

        public DescontoImpostoRendaContext()
           : base("DescontoImpostoRendaConnection")
        {
            //Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer<DescontoImpostoRendaContext>(null);
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());
        }

        public static DescontoImpostoRendaContext Create()
        {
            return new DescontoImpostoRendaContext();
        }
    }
}
