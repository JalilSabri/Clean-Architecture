using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CleanArch.Core.Domain.Entites.Common;

namespace CleanArch.Core.Domain.Models.Persons
{
    [Table("tblPerson")]
    public class Person : TBaseEntity<int>
    {
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
    }
}
