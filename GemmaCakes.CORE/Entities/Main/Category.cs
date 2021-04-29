using GemmaCakes.CORE.Entities.Common;
using System;
using System.Collections.Generic;

namespace GemmaCakes.CORE.Entities.Main
{
    public class Category : BaseEntity
    {
        public ICollection<Cake> Cakes { get; set; }
    }
}
