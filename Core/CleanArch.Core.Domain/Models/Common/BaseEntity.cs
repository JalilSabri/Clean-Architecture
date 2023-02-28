using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Domain.Common
{
    public abstract class TBaseEntity<IdType>
    {
        public IdType Id { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

   
}

