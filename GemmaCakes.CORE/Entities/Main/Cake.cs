using GemmaCakes.CORE.Entities.Common;
using System;
using System.Collections.Generic;

namespace GemmaCakes.CORE.Entities.Main
{
    public class Cake : BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        //-------------------------------

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
