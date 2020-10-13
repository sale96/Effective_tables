using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.DataAccess
{
    public interface IContextConfiguration
    {
        string GetConnectionString();
    }
}
