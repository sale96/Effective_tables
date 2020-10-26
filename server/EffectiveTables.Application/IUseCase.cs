using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.Application
{
    public interface IUseCase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
