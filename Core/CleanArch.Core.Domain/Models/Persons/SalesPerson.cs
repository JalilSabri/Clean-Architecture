using CleanArch.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Domain.Models.Persons
{
    [Table("tblSalesPersons")]
    public class SalesPerson : TBaseEntity<string>
    {
        public SalesPerson()
        {
            Id = Guid.NewGuid().ToString();
        }

        [MaxLength(150)]
        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [MaxLength(150)]
        [Display(Name = "Phone No")]
        public string? Phone { get; set; }

        [MaxLength(150)]
        [Display(Name = "City")]
        public string? City { get; set; }

        [MaxLength(150)]
        [Display(Name = "State")]
        public string? State { get; set; }

        [MaxLength(150)]
        [Display(Name = "Zip Code")]
        public string? ZipCode { get; set; }

        public int PersonId { get; set; }

        public Person person { get; set; }
    }
}
