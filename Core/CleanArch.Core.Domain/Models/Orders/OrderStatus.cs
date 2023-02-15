using CleanArch.Core.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Domain.Models.Orders
{
    [Table("tblOrderStatus")]
    public class OrderStatus : TBaseEntity<int>
    {
        [Required]
        [MaxLength(50)]
        public string? OrderStatusTitle { get; set; }
    }
}
