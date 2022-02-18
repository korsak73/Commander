using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HoTow="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, HoTow="Cut a bread", Line="Get a knife", Platform="knihe & chopping board"},
                new Command{Id=2, HoTow="Make cup of tea", Line="Place teabag in cup", Platform="Kettle & Cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HoTow="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }
    }
}