using Cascardi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Cascardi.DAL
{
    public class CascardiContext : DbContext
    {
        public CascardiContext() : base("CascardiContext")
        {
            Database.SetInitializer(new CascardiInitializer());
        }

        public IDbSet<RelatorioCustos> RelatorioCustos { get; set; }
        public IDbSet<RelatorioProdutosMaisVendidos> RelatorioProdutosMaisVendidos { get; set; }
        public IDbSet<RelatorioRentabilidade> RelatorioRentabilidade { get; set; }
        public IDbSet<RelatorioVendas> RelatorioVendas { get; set; }

        public IDbSet<Vendor> Vendors { get; set; }
    }
}