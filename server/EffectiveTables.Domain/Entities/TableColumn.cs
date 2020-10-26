using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.Domain.Entities
{
    public class TableColumn : BaseEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public int TableId { get; set; }
        public virtual Table Table { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<ColumnLog> ColumnLogs { get; set; }
    }
}
