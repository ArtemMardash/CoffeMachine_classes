using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_classes
{
    public class ShowCommands:ICommand
    {
        private string[] _commands;
        public ShowCommands(params string[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (string command in _commands)
            {
                Console.WriteLine(command);
            }
        }
    }
}
