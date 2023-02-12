using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Domain.Models.Draft
{
    [Table("tblDraft")]
    public class DraftEntity
    {
        //public Person()
        //{
        //    this.Id.
        //}
        //public int PersonId { get; set; }

        //public string NationalCode { get; init; }

        //[MaxLength(100)]
        //[Display(Name = "First Name")]
        //public string? FirstName { get; set; }

        ////[MaxLength(100)]
        //[Required]
        //[Column("Family", TypeName = "nvarchar(150)")]
        //[Display(Name = "Last Name")]
        //public int? LastName { get; set; }

        //[NotMapped()]
        //public string FullName { get => $"{FirstName ?? "No Name"} {LastName}"; }
    }

    public class CustomColumnAttribute : ColumnAttribute
    {
        //private string _key;

        //public CustomColumnAttribute(string key)
        //{
        //    _key = key;
        //}


        //public override string DisplayName =>
        //    Regex.Replace(Regex.Replace(_key,
        //        "(\\P{Ll})(\\P{Ll}\\p{Ll})", "$1 $2"), "(\\p{Ll})(\\P{Ll})", "$1 $2");
    }
}
