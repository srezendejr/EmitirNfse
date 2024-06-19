using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Configuration;

namespace EmitirNfse.Dados
{
    public class DadosContext : DbContext
    {
        public DadosContext()
            : base("name=CnnEmitirNfse")
        {
        }
        public DadosContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        { 
        }

        public DbSet<Modelos.Empresas> EmpresaSet { get; set; }
        public DbSet<Modelos.IdentificacaoRPS> IdentificaRpsSet { get; set; }
        public DbSet<Modelos.Cep> CepSet { get; set; }
        public DbSet<Modelos.InfNfse> Nfse { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();            
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            //base.OnModelCreating(modelBuilder);
        }
    }
}
