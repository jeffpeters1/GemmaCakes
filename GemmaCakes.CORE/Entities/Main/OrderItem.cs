using GemmaCakes.CORE.Entities.Common;
using System;

namespace GemmaCakes.CORE.Entities.Main
{
    public class OrderItem : BaseEntity
    {
        public Guid CakeId { get; set; }

        public Cake Cake { get; set; }

        public float Quantity { get; set; }

        public Guid OrderId { get; set; }

        public Order Order { get; set; }
    }
}
