using CleanArch.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Domain.Models.Products
{
    [Table("tblProducts")]
    public class Product : TBaseEntity<string>
    {
        public Product()
        {
            Id = Guid.NewGuid().ToString();
        }

        [MaxLength(150)]
        public string ProductName { get; set; }

        public int? Size { get; set; }

        [MaxLength(150)]
        public string? Varienty { get; set; }

        public float Price { get; set; }

        [MaxLength(150)]
        public string Status { get; set; }
       
	}
}
