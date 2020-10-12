using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.Domain
{
    public class TableColumn : BaseEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}
