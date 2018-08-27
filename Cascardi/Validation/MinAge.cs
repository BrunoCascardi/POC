using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cascardi.Validation
{
    public class MinAge : ValidationAttribute
    {
        private int _Limit;
        public MinAge(int Limit)
        {
            this._Limit = Limit;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                DateTime bday = DateTime.Parse(value.ToString());
                DateTime today = DateTime.Today;
                int age = today.Year - bday.Year;
                if (bday > today.AddYears(-age))
                {
                    age--;
                }
                if (age < _Limit)
                {
                    var result = new ValidationResult("Deve ter no mínimo 18 anos de idade");
                    return result;
                }


                return null;
            }
            catch (Exception)
            {
                var result = new ValidationResult("O campo Data de Nascimento é obrigatório");
                return result;
            }

        }
    }
}