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

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo="Go for a walk with dog", Line="To wear some clothes.", Platform="Street and fresh air."},
                new Command{Id = 1, HowTo="Will install Windwos", Line="Use flash.", Platform="Windows"},
                new Command{Id = 2, HowTo="Update old windpws version", Line="Check and update", Platform="Windows 7+"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo="Go for a walk with dog", Line="To wear some clothes.", Platform="Street and fresh air."};
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