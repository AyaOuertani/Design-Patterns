using System.Windows.Input;
using Command.Interface;

namespace Command.Invoker
{
    public class RemoteControl
    {
        private ITvCommand _Command;
        private readonly Stack<ITvCommand> _CommandHistory = new Stack<ITvCommand>();

        public void SetCommand(ITvCommand command)
        {
            _Command = command;
        }

        public void PressButton()
        {
            _Command.Execute();
            _CommandHistory.Push(_Command);
        }

        public void Undo()
        {
            if (_CommandHistory.Any())
            {
                ITvCommand lastCommand = _CommandHistory.Pop();
                lastCommand.Undo();
            }
        }
    }

}
