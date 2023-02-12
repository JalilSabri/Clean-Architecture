using CleanArch.Core.Domain.Entites.Common;
using CleanArch.Core.Domain.Models.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Domain.Models.Order
{
    [Table("tblOrders")]
    public class Orders : TBaseEntity<string>
    {
        public Orders()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Total")]
        public float Total { get; set; }

        [Required]
        [Column(Order = 1)]
        public string CustomerId { get; set; }
        public Customer customer { get; set; }

        [Required]
        [Column(Order = 2)]
        public string SalesPerId { get; set; }
        public SalesPerson salesPerson { get; set; }

        [Required]
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}
