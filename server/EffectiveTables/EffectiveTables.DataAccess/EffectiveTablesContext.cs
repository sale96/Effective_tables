using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.DataAccess
{
    public class EffectiveTablesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer();
            base.OnConfiguring(builder);
        }
    }
}
