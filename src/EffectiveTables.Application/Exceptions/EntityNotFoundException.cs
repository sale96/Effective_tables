using System;

namespace EffectiveTables.Application.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(int id, Type type)
            : base($"Entity of type {type.Name} with id {id.ToString()} was not found.")
        {
            
        }
    }
}