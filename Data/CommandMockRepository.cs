using System.Linq;
namespace Commander.Data
{
    public class CommandMockRepository : object
    {
        public CommandMockRepository() :base()
        {
            
        }
        private System.Collections.Generic.List<Models.Command> _commands;
        protected virtual System.Collections.Generic.List<Models.Command> Commands { 
                get
                    {
                        if (_commands == null)
                        {
                            _commands =
                                 new System.Collections.Generic.List<Models.Command>();
                        }
                        if  (_commands.Any() == false)
                        {
                            for(int index = 1; index <= 10; index++)
                            {
                                Models.Command newCommand = 
                                    new Models.Command
                                    {
                                        Id = index,
                                        Line = $"Line{ index }",
                                        HowTo = $"How To{ index }",
                                        Platform = $"Platform{ index }",
                                    };
                                _commands.Add(newCommand);
                            }
                        }
                        return _commands;
                    }
            }
            public Models.Command GetById(int id)
            {
                Models.Command foundedCommand = 
                    Commands.Where(current => current.Id == id)
                    .FirstOrDefault();
                return foundedCommand;
            }

            public System.Collections.Generic.IEnumerable<Models.Command> GetAll()
            {
                return Commands;
            }
    }
}