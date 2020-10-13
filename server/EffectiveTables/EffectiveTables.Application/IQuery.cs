using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveTables.Application
{
    public interface IQuery<TSearch, TRequest> : IUseCase
    {
        TRequest Execute(TSearch serach);
    }
}
