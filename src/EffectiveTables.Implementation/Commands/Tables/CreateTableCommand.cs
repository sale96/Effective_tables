using EffectiveTables.Application.Commands.Tables;
using EffectiveTables.Application.Dto;

namespace EffectiveTables.Implementation.Commands.Tables
{
    public class CreateTableCommand : ICreateTableCommand
    {
        public int Id => 1;
        public string Name => "Create table command";
        
        public void Execute(DtoTable request)
        {
        }
    }
}