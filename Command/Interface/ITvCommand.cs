using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Interface
{
    public interface ITvCommand
    {
        public void Execute();
        public void Undo();
    }
}
