using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommandRepo
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
                new Command { Id = 0, HowTo = "Boil a egg", Line = "Boil water", Plataform = "Test" },
                new Command { Id = 0, HowTo = "Cut bread", Line = "Get a knife", Plataform = "Knife and beer" },
                new Command { Id = 0, HowTo = "Make cup of tea", Line = "Place teabag in cup", Plataform = "Teabag" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil a egg", Line = "Boil water", Plataform = "Test" };
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