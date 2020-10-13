using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Description { get; set; }
        public int Likes { get; set; }

        public int CardId { get; set; }
        public virtual Card Card { get; set; }
    }
}
