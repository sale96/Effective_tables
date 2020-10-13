using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.Domain.Entities
{
    public class TableLog : BaseEntity
    {
        public string Description { get; set; }
        public DateTime LogTime { get; set; }
        public int TableId { get; set; }
        public virtual Table Table { get; set; }
    }
}
