using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using EffectiveTables.Domain.Entities;

namespace EffectiveTables.DataAccess
{
    public class EffectiveTablesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionString = String.Empty;

            var open = File.ReadLines($@"{Directory.GetCurrentDirectory()}/Configuration/.env");

            connectionString = open.First().Trim();
            
            builder.UseSqlServer(connectionString);
            base.OnConfiguring(builder);
        }
        
        public DbSet<Table> Tables { get; set; }
        public DbSet<TableColumn> TableColumns { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CardLog> CardLogs { get; set; }
        public DbSet<TableLog> TableLogs { get; set; }
        public DbSet<CardLabel> CardLabels { get; set; }
    }
}
