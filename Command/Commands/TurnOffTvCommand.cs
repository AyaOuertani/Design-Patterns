using Command.Interface;
using Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class TurnOffTvCommand : ITvCommand
    {
        private  TV _TV;
        public TurnOffTvCommand(TV tv)
        {
            _TV = tv;
        }
        public void Execute()
        {
            _TV.TurnOff();
        }

        public void Undo()
        {
            _TV.TurnOn();
        }
    }
}
