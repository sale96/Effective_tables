using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.DataAccess
{
    public class EffectiveTablesContext : DbContext
    {
        private readonly IContextConfiguration _configuration;
        public EffectiveTablesContext(IContextConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_configuration.GetConnectionString());
            base.OnConfiguring(builder);
        }
    }
}
