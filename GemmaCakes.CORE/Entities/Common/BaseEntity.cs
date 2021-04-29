using System;

namespace GemmaCakes.CORE.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

    }
}
