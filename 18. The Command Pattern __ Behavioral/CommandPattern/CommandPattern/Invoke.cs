using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Invoke
    {
        ICommand _commandToBePerformed;
        public void SetCommand(ICommand command)
        {
            _commandToBePerformed = command;
        }
        public void ExecuteCommand()
        {
            _commandToBePerformed.DO();
        }
    }
}
