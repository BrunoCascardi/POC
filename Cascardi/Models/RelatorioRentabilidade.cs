
using Cascardi.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Cascardi.Models
{
    public class RelatorioRentabilidade
    {
        public RelatorioRentabilidade()
        {
        }

        public int Id { get; set; }

        public int Valor { get; set; }
    }
}