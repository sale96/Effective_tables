using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.Domain.Entities
{
    public class Card : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public int CardLabelId { get; set; }
        public CardLabel CardLabel { get; set; }

        public int TableColumnId { get; set; }
        public virtual TableColumn TableColumn { get; set; }
    }
}
