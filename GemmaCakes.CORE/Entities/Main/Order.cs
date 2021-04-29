using GemmaCakes.CORE.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GemmaCakes.CORE.Entities.Main
{
    public class Order : BaseEntity
    {
        public Guid UserId { get; set; }

        public decimal Total { get; set; }

        public DateTime OrderDate { get; set; }

        public bool IsPaid { get; set; }

        //---------------------

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
