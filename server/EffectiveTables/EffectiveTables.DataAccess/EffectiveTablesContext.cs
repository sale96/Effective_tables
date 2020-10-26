using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace EffectiveTables.DataAccess
{
    public class EffectiveTablesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionString = "";

            if (
                RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || 
                RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                connectionString = Environment.GetEnvironmentVariable("EFFECTIVE_TABLES_CONNECTION_UNIX");
            } else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                connectionString = Environment.GetEnvironmentVariable("EFFECTIVE_TABLES_CONNECTION_WIN");
            }
            
            builder.UseSqlServer(connectionString);
            base.OnConfiguring(builder);
        }
    }
}
