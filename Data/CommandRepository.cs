using System.Collections.Generic;
using Models;
using System.Linq;

namespace Commander.Data
{
    public class CommandRepository : object, ICommandRepository
    {
        public CommandRepository() : base()
        {
            
        }

        private System.Collections.Generic.List<Models.Command> _commands;

        protected virtual System.Collections.Generic.List<Models.Command> Commands
         { 
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
        public Models.Command GetById(int Id)
        {
                Models.Command foundedCommand = 
                    Commands.Where(current => current.Id == Id)
                    .FirstOrDefault();
                return foundedCommand;
        }
        public IEnumerable<Command> GetAll()
        {
            return Commands;
        }

        
    }
}