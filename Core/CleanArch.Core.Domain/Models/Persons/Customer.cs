using CleanArch.Core.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Domain.Models.Persons
{
    [Table("tblCustomer")]
    public class Customer : TBaseEntity<string>
    {
        public Customer()
        {
            Id = Guid.NewGuid().ToString();
        }

        [MaxLength(150)]
        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [MaxLength(150)]
        [Display(Name = "Phone No")]
        public string? Phone { get; set; }

        [Column(Order = 2)]
        public int CustomerPersonId { get; set; }

        [ForeignKey("CustomerPersonId")]
        public Person person { get; set; }
    }
}
