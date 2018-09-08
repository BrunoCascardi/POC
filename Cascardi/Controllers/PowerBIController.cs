using Cascardi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cascardi.Controllers
{
    public class PowerBIController : Controller
    {
        private CascardiContext db = new CascardiContext();

        // GET: PowerBI
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RelatorioCustos()
        {
            Models.RelatorioCustos rl = new Models.RelatorioCustos()
            {
                Id = 1,
                Valor = 100
            };
            db.RelatorioCustos.Add(rl);
            db.SaveChanges();

            return View("Index");
        }

        public ActionResult RelatorioProdutosMaisVendidos()
        {
            for (int i = 0; i < 10; i++)
            {
                Models.RelatorioProdutosMaisVendidos rl = new Models.RelatorioProdutosMaisVendidos()
                {
                    Id = 1,
                    Codigo = "CD" + i,
                    CodigoDeBarras = "RL00" + i,
                    Descricao = "Produto " + i,
                    Quantidade = 1 * (i + 1),
                    ValorUnitario = 10,
                    Total = (1 * (i + 1)) * 10
                };
                db.RelatorioProdutosMaisVendidos.Add(rl);
            }

            db.SaveChanges();

            return View("Index");
        }

        public ActionResult RelatorioRentabilidade()
        {
            Models.RelatorioRentabilidade rl = new Models.RelatorioRentabilidade()
            {
                Id = 1,
                Valor = 100
            };
            db.RelatorioRentabilidade.Add(rl);
            db.SaveChanges();

            return View("Index");
        }

        public ActionResult RelatorioVendas()
        {
            Models.RelatorioVendas rl = new Models.RelatorioVendas()
            {
                Id = 1,
                Valor = 100
            };
            db.RelatorioVendas.Add(rl);
            db.SaveChanges();

            return View("Index");
        }
    }
}