﻿using CleanArch.Core.Domain.Entites.Common;
using CleanArch.Core.Domain.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Domain.Models.Order
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
        public Orders orders { get; set; }

        [Required]
        [Column(Order = 2)]
        public string ProductId { get; set; }
        public Products products { get; set; }

    }
}
