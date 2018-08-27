using Cascardi.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Cascardi.Models
{
    public class Customer
    {
        public Customer()
        {
        }

        public int Id { get; set; }

        [MaxLength(25)]
        [DisplayName("Primeiro Nome")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Último Nome")]
        public string LastName { get; set; }

        [Required]
        [MinAge(18)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }

        [MaxLength(5000)]
        [DisplayName("Endereço")]
        public string Address { get; set; }
    }
}