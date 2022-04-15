using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
            new Command{Id=0, HowTo="Boil an egg", Line="Boil", Platform="hh"},
            new Command{Id = 1, HowTo = "Boil an egg", Line = "Boil", Platform = "hh" },
            };
            
            return commands;
        }

    public Command GetCommandById(int id)
    {
        return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil", Platform = "hh" };
    }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}