using Cascardi.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Cascardi.Models
{
    public class RelatorioCustos
    {
        public RelatorioCustos()
        {
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

    }
}