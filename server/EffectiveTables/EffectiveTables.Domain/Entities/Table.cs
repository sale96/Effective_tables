using System.Collections.Generic;

namespace EffectiveTables.Domain.Entities
{
    public class Table : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<TableColumn> TableCollumns { get; set; }
    }
}
