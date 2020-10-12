using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.Domain.Entities
{
    public class ColumnLog : BaseEntity
    {
        public string Description { get; set; }
        public DateTime LogTime { get; set; }
        public int TableColumnId { get; set; }
        public TableColumn TableColumn { get; set; }
    }
}
