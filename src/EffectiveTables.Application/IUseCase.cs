using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.Application
{
    public interface IUseCase
    {
        public int Id { get; }
        public string Name { get; }
    }
}
