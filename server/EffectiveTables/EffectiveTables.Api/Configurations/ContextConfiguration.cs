using EffectiveTables.DataAccess;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EffectiveTables.Api.Configurations
{
    public class ContextConfiguration : IContextConfiguration
    {
        private readonly IConfiguration _configuration;
        public ContextConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }
    }
}
