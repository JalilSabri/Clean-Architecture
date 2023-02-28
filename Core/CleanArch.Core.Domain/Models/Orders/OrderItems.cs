using CleanArch.Core.Domain.Common;
using CleanArch.Core.Domain.Models.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Core.Domain.Models.Orders
{
    [Table("tblOrderItems")]
    public class OrderItems : TBaseEntity<string>
    {
        public OrderItems()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Required]
        [Display(Name = "Quantity")]
        public float Quantity { get; set; }

        [Required]
        [Column(Order = 1)]
        public string OrderId { get; set; }
        public Order orders { get; set; }

        [Required]
        [Column(Order = 2)]
        public string ProductId { get; set; }
        public Product products { get; set; }

    }
}
