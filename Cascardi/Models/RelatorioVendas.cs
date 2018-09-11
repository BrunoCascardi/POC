using Cascardi.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Cascardi.Models
{
    public class RelatorioVendas
    {
        public RelatorioVendas()
        {
        }

        public int Id { get; set; }
        public string Mes { get; set; }
        public double Valor { get; set; }
    }
}