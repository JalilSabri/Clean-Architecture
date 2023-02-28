using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CleanArch.Core.Domain.Common;

namespace CleanArch.Core.Domain.Models.Persons
{
    [Table("tblPersons")]
    public class Person : TBaseEntity<int>
    {
        //public int Id { get; set; }

        [MaxLength(100)]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [MaxLength(100)]
        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [NotMapped()]
        [Display(Name = "Full Name")]
        public string FullName { get => $"{FirstName ?? "No Name"} {LastName}"; }

        public Customer customers { get; set; }

        public SalesPerson salesPerson { get; set; }
    }
}
